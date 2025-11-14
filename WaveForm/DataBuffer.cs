using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class DataBuffer
    {
        // 模擬データを格納するためのリスト
        private List<(DateTime time, int value)> valuelist = new List<(DateTime time, int value)>();

        private const int MAX_DATA_COUNT = 30;

        // リストへの追加
        public void AddData(DateTime time,int value)
        {
            valuelist.Add((time,value));

            // 最大件数を超えた場合、古いデータを削除
            if (valuelist.Count > MAX_DATA_COUNT)
            {
                valuelist.RemoveAt(0);
            }
        }

        public List<(DateTime time, int value)> GetValues()
        {
            return valuelist; 
        }
    }
}
