using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Diagnostics;

namespace WaveForm
{
    internal class DataController
    {
        // データ生成完了通知用デリゲート
        public Action<int>? DataGenerated;
        // チャート更新用デリゲート
        public Action<List<(DateTime time, int value)>>? ChartUpdate;
        // 解析完了通知用デリゲート
        public Action<double, int, int>? DataAnalyzed;
        // アラート通知用デリゲート
        public Action? DataAlerted;

        // DataGeneratorクラス
        private readonly DataGenerator generator;
        // DataBufferクラス
        private readonly DataBuffer buffer;
        // DataAnalyzerクラス
        private readonly DataAnalyzer analyzer;
        // CsvLoggerクラス
        private readonly CsvLogger logger;
        // Timerクラス
        private readonly System.Windows.Forms.Timer timer = null!;
        // バイナリデータを10進数に変換した値
        private int currentvalue;
        // 前回のアラート状態
        private bool previousalert = false;

        // MainForm を受け取るコンストラクタ
        public DataController()
        {
            generator = new DataGenerator();
            buffer = new DataBuffer();
            analyzer = new DataAnalyzer();
            logger = new CsvLogger();
            timer = new System.Windows.Forms.Timer();

            currentvalue = 0;
        }

        // インターバル設定メソッド
        public void SetInterval(int interval)
        {
            timer.Interval = interval;
        }

        // 閾値設定メソッド
        public void SetThreshold(int threshold)
        {
            analyzer.Threshold = threshold;
        }

        // スタートメソッド
        public void Start()
        {
            // イベントハンドラの再登録防止
            timer.Tick -= Timer_Tick;
            // イベントハンドラ登録
            timer.Tick += Timer_Tick;
            // タイマー開始
            timer.Start();
        }

        // ストップメソッド
        public void Stop()
        {
            // タイマー停止
            timer.Stop();
        }

        private void Timer_Tick(object? sender, EventArgs? e)
        {
            // 現在日時取得
            DateTime now = DateTime.Now;

            // バイナリデータ取得
            currentvalue = generator.Generate();

            // データの格納
            buffer.AddData(now, currentvalue);

            // データリストの取得
            List<(DateTime time, int value)> values = buffer.GetValues();

            // 解析用リスト
            List<int> analyzes = values.Select(v => v.value).ToList();

            // 解析実施
            analyzer.Analyze(analyzes);

            // データ生成完了通知
            DataGenerated?.Invoke(currentvalue);

            // チャート更新
            ChartUpdate?.Invoke(values);

            // データ解析完了通知
            DataAnalyzed?.Invoke(analyzer.Average, analyzer.Max, analyzer.Min);

            if (analyzer.IsAlert && !previousalert)
            {
                // 正常→異常の遷移を検出
                // アラート通知
                DataAlerted?.Invoke();

                // アラートログ書き込み
                logger.WriteAlertLog(now,"異常値を検知" ,currentvalue);
            }
            else if (!analyzer.IsAlert && previousalert)
            {
                // 異常→正常の遷移を検出
                // アラートログ書き込み
                logger.WriteAlertLog(now, "異常値から復帰", currentvalue);
            }
                
            // 前回のアラート状態を保存
            previousalert = analyzer.IsAlert;

            // データログ書き込み
            logger.WriteLog(now, currentvalue, analyzer.Average, analyzer.Max, analyzer.Min, analyzer.IsAlert);
        }
    }
}
