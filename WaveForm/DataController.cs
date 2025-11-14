using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveForm
{
    internal class DataController
    {
        // DataGeneratorクラス
        private readonly DataGenerator generator;
        // DataBufferクラス
        private readonly DataBuffer databuf;
        // Timerクラス
        private readonly System.Windows.Forms.Timer timer = null!;

        // データ生成完了通知用デリゲート
        public Action<int>? DataGenerated;

        // チャート更新用デリゲート
        public Action<List<(DateTime time, int value)>>? ChartUpdate;

        // バイナリデータを10進数に変換した値
        private int currentvalue;

        // MainForm を受け取るコンストラクタ
        public DataController()
        {
            generator = new DataGenerator();
            databuf = new DataBuffer();
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
            databuf.AddData(DateTime.Now, currentvalue);

            // データリストの取得
            List<(DateTime time, int value)> values = databuf.GetValues();

            // データ生成完了通知
            DataGenerated?.Invoke(currentvalue);

            // チャート更新
            ChartUpdate?.Invoke(values);
        }
    }
}
