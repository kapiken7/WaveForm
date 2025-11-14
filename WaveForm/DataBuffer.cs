using System;
using System.Collections.Generic;
using System.Text;

namespace WaveForm
{
    internal class DataBuffer
    {
        // データを保持するための構造体
        internal struct DataPoint
        {
            internal DateTime time;
            internal int value;
        }

        // 模擬データを格納するためのリスト
        private List<DataPoint> valuelist = new List<DataPoint>();

        private const int MAX_DATA_COUNT = 30;

        // リストへの追加
        public void AddData(DateTime time,int value)
        {
            DataPoint tmpdata = new DataPoint();

            tmpdata.time = time;
            tmpdata.value = value;

            valuelist.Add(tmpdata);

            // 最大件数を超えた場合、古いデータを削除
            if (valuelist.Count > MAX_DATA_COUNT)
            {
                valuelist.RemoveAt(0);
            }
        }

        public List<DataPoint> GetValues()
        {
            return valuelist; 
        }
    }
}
