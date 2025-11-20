using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class CsvLogger
    {
        // ログ書き込みエラー通知用デリゲート
        public Action<string>? LogErrorOccurred;

        // UTF-8 BOM付きエンコーディング
        private static readonly System.Text.Encoding utf8EncodingWithBom = new UTF8Encoding(true);

        public CsvLogger(){}

        // データログへの書き込み
        public void WriteLog(DateTime time,int value,double average, int max, int min,bool isAlert)
        {
            string todayFile = $"DataLog_{time:yyyyMMdd}.csv";
            string header = "日時,値,平均値,最大値,最小値,しきい値判定\n";

            try
            {
                // ログファイルの存在確認とヘッダー書き込み
                EnsureHeader(todayFile, header);

                // 正常／異常判定
                string status = isAlert ? "異常" : "正常";

                // ログ追記
                File.AppendAllText(todayFile, $"{time},{value},{average},{max},{min},{status}\n", utf8EncodingWithBom);
            }
            catch (Exception ex)
            {
                // ログ書き込みエラー通知
                LogErrorOccurred?.Invoke($"データログ書き込みエラー: {ex.Message}");
            }
        }

        // アラートログへの書き込み
        public void WriteAlertLog(DateTime time,string message, int value)
        {
            string todayFile = $"AlertLog_{time:yyyyMMdd}.csv";
            string header = "日時,メッセージ,値\n";

            try
            {
                // ログファイルの存在確認とヘッダー書き込み
                EnsureHeader(todayFile, header);

                // ログ追記
                File.AppendAllText(todayFile, $"{time},{message},{value}\n", utf8EncodingWithBom);
            }
            catch (Exception ex)
            {
                // ログ書き込みエラー通知
                LogErrorOccurred?.Invoke($"アラートログ書き込みエラー: {ex.Message}");
            }
        }

        // ログファイルの存在確認とヘッダー書き込み
        private void EnsureHeader(string filePath, string header)
        {
            if (!File.Exists(filePath))
            {
                // ファイルが存在しなければヘッダーを書き込む
                File.WriteAllText(filePath, header, utf8EncodingWithBom);
            }
        }
    }
}