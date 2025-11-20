using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class CsvLogger
    {
        // UTF-8 BOM付きエンコーディング
        private System.Text.Encoding utf8EncodingWithBom;

        public CsvLogger()
        {
            utf8EncodingWithBom = new UTF8Encoding(true);
        }

        // データログへの書き込み
        public void WriteLog(DateTime time,int value,double average, int max, int min,bool isAlert)
        {
            string todayFile = $"DataLog_{time:yyyyMMdd}.csv";

            if (!File.Exists(todayFile))
            {
                // ファイルが存在しなければヘッダーを書き込む
                File.WriteAllText(todayFile, "日時,値,平均値,最大値,最小値,しきい値判定\n",utf8EncodingWithBom);
            }

            // 正常／異常判定
            string status = isAlert ? "異常" : "正常";

            // ログ追記
            File.AppendAllText(todayFile, $"{time},{value},{average},{max},{min},{status}\n", utf8EncodingWithBom);
        }

        // アラートログへの書き込み
        public void WriteAlertLog(DateTime time,string message, int value)
        {
            string todayFile = $"AlertLog_{time:yyyyMMdd}.csv";

            if (!File.Exists(todayFile))
            {
                // ファイルが存在しなければヘッダーを書き込む
                File.WriteAllText(todayFile, "日時,メッセージ,値\n",utf8EncodingWithBom);
            }

            // ログ追記
            File.AppendAllText(todayFile, $"{time},{message},{value}\n",utf8EncodingWithBom);
        }
    }
}
