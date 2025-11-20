using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace WaveForm
{
    internal class DataAnalyzer
    {
        // メンバ変数
        // 統計値
        private double average;
        private int max;
        private int min;
        // 閾値
        private int threshold;
        // アラートフラグ
        private bool isAlert;

        internal DataAnalyzer() 
        {
            average = 0.0;
            max = 0;
            min = 0;
            threshold = 0;
            isAlert = false;
        }

        // メンバ変数のプロパティ
        // 統計値の読み取り
        public double Average
        {
            get { return average; }
        }
        public int Max
        {
            get { return max; }
        }
        public int Min
        {
            get { return min; }
        }
        // 閾値の読み書き
        public int Threshold
        {
            get { return threshold; }
            set { threshold = value; }
        }
        // アラートフラグの読み取り
        public bool IsAlert
        {
            get { return isAlert; }
        }

        public void Analyze(List<int> values)
        {
            if (values?.Count > 0)
            {
                // リストがnullもしくは空でなければ処理
                // メンバ変数更新
                average =　values.Average(v => v);
                max = values.Max(v => v);
                min = values.Min(v => v);

                // 四捨五入して小数点第1位までの数値にする
                average = Math.Round(average, 1);

                // 閾値チェック
                isAlert = (values.Last() > threshold);
            }
        }
    }
}
