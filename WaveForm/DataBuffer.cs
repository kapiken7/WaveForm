using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class DataBuffer
    {
        // 模擬データを格納するためのリスト
        private List<(DateTime time, int value)> valueList;

        // 最大データ件数
        private const int MAX_DATA_COUNT = 20;

        internal DataBuffer()
        {
            valueList = new List<(DateTime time, int value)>();
        }

        // リストへの追加
        public void AddData(DateTime time,int value)
        {
            valueList.Add((time,value));

            // 最大件数を超えた場合、古いデータを削除
            if (valueList.Count > MAX_DATA_COUNT)
            {
                valueList.RemoveAt(0);
            }
        }

        public List<(DateTime time, int value)> GetValues()
        {
            return valueList; 
        }
    }
}
