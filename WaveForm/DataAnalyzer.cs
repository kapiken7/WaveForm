using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace WaveForm
{
    internal class DataAnalyzer
    {
        // プロパティ
        // 平均値
        public double Average { get; private set; }
        // 最大値
        public int Max { get; private set; }
        // 最小値
        public int Min { get; private set; }
        // しきい値
        public int Threshold { get; set; }
        // アラートフラグ
        public bool IsAlert { get; private set; }

        internal DataAnalyzer() 
        {
            Average = 0.0;
            Max = 0;
            Min = 0;
            Threshold = 0;
            IsAlert = false;
        }

        public void Analyze(List<int> values)
        {
            if (values == null || values.Count == 0)
            {
                // リストがnullもしくは空ならメンバ変数を初期化
                Average = 0.0;
                Max = 0;
                Min = 0;
                Threshold = 0;
                IsAlert = false;
                return;
            }

            // 統計値算出
            Average = Math.Round(values.Average(), 1);
            Max = values.Max();
            Min = values.Min();

            // しきい値チェック
            IsAlert = (values.Last() > Threshold);
        }
    }
}