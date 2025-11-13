using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class DataController
    {
        // DataGeneratorクラス
        private readonly DataGenerator generator;
        // Timerクラス
        private readonly System.Windows.Forms.Timer timer;

        // データ生成完了通知用デリゲート
        public Action<int>? DataGenerated;

        // バイナリデータを10進数に変換した値
        private int currentvalue;

        // MainForm を受け取るコンストラクタ
        public DataController()
        {
            generator = new DataGenerator();
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // バイナリデータ取得
            currentvalue = generator.Generate();

            // データ生成完了通知
            DataGenerated?.Invoke(currentvalue);
        }
    }
}
