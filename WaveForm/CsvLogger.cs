using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class CsvLogger
    {
        // UTF-8 BOM付きエンコーディング
        private System.Text.Encoding utf8WithBom;
        public CsvLogger()
        {
            utf8WithBom = new UTF8Encoding(true);
        }

        // データログへの書き込み
        public void WriteLog(DateTime time,int value,double average, int max, int min,bool isalert)
        {
            string todayfile = $"DataLog_{time:yyyyMMdd}.csv";

            if (!File.Exists(todayfile))
            {
                // ファイルが存在しなければヘッダーを書き込む
                File.WriteAllText(todayfile, "日時,値,平均値,最大値,最小値,しきい値判定\n",utf8WithBom);
            }

            // 正常／異常判定
            string status = isalert ? "異常" : "正常";

            // ログ追記
            File.AppendAllText(todayfile, $"{time},{value},{average},{max},{min},{status}\n", utf8WithBom);
        }

        // アラートログへの書き込み
        public void WriteAlertLog(DateTime time,string message, int value)
        {
            string todayfile = $"AlertLog_{time:yyyyMMdd}.csv";

            if (!File.Exists(todayfile))
            {
                // ファイルが存在しなければヘッダーを書き込む
                File.WriteAllText(todayfile, "日時,メッセージ,値\n",utf8WithBom);
            }

            // ログ追記
            File.AppendAllText(todayfile, $"{time},{message},{value}\n",utf8WithBom);
        }
    }
}
