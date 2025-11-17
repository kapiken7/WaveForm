using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace WaveForm
{
    internal class DataController
    {
        // DataGeneratorクラス
        private readonly DataGenerator generator;
        // DataBufferクラス
        private readonly DataBuffer buffer;
        // DataAnalyzerクラス
        private readonly DataAnalyzer analyzer;
        // Timerクラス
        private readonly System.Windows.Forms.Timer timer = null!;

        // データ生成完了通知用デリゲート
        public Action<int>? DataGenerated;

        // チャート更新用デリゲート
        public Action<List<(DateTime time, int value)>>? ChartUpdate;

        // 解析完了通知用デリゲート
        public Action<double,int,int>? DataAnalyzed; 

        // バイナリデータを10進数に変換した値
        private int currentvalue;

        // MainForm を受け取るコンストラクタ
        public DataController()
        {
            generator = new DataGenerator();
            buffer = new DataBuffer();
            analyzer = new DataAnalyzer();
            timer = new System.Windows.Forms.Timer();

            currentvalue = 0;
        }

        // スタートメソッド
        public void Start()
        {
            // タイマー設定＆開始
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
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
            // バイナリデータ取得
            currentvalue = generator.Generate();

            // データの格納
            buffer.AddData(DateTime.Now, currentvalue);

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
            DataAnalyzed?.Invoke(analyzer.Average,analyzer.Max,analyzer.Min);
        }
    }
}
