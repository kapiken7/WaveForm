using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WaveForm
{
    internal class DataAnalyzer
    {
        private double average;
        private int max;
        private int min;

        internal DataAnalyzer() 
        {
            average = 0.0;
            max = 0;
            min = 0;
        }

        // メンバ変数のプロパティ(読み取り専用)
        public double Average { get { return average; } }
        public int Max { get { return max; } }
        public int Min { get { return min; } }

        public void Analyze(List<int> values)
        {
            // リストがnullもしくは空でなければ処理
            if (values?.Count > 0)
            {
                // メンバ変数更新
                average =　values.Average(v => v);
                max = values.Max(v => v);
                min = values.Min(v => v);

                // 四捨五入して小数点第1位までの数値にする
                average = Math.Round(average, 1);
            }
        }
    }
}
