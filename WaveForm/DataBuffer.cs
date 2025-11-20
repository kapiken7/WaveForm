using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class DataBuffer
    {
        // 模擬データを格納するためのリスト
        private List<(DateTime time, int value)> dataBuffer;

        // 最大データ件数
        private const int Max_Data_Count = 20;

        internal DataBuffer()
        {
            dataBuffer = new List<(DateTime time, int value)>();
        }

        // リストへの追加
        public void AddData(DateTime time,int value)
        {
            dataBuffer.Add((time,value));

            // 最大件数を超えた場合、古いデータを削除
            if (dataBuffer.Count > Max_Data_Count)
            {
                dataBuffer.RemoveAt(0);
            }
        }

        // リストの取得
        public List<(DateTime time, int value)> GetValues()
        {
            return new List<(DateTime time, int value)>(dataBuffer); 
        }
    }
}