using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class CsvLogger
    {
        // アラートログへの書き込み
        public void WriteAlertLog(DateTime time, int value)
        {
            string todayfile = $"AlertLog_{time:yyyyMMdd}.csv";

            // ファイルが存在しなければヘッダーを書き込む
            if (!File.Exists(todayfile))
            {
                File.WriteAllText(todayfile, "Time,Value\n");
            }

            // ログ追記
            File.AppendAllText(todayfile, $"{time},{value}\n");
        }
    }
}
