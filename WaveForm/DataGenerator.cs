using System;
using System.Diagnostics;

namespace WaveForm
{
    internal class DataGenerator
    {
        // 乱数生成用
        private static readonly Random random = new Random();

        public DataGenerator(){}

        public int Generate()
        {
            // 2バイト分の配列作成
            byte[] binarydata = new byte[2];

            // バイナリデータの乱数作成
            random.NextBytes(binarydata);

            // 10進数に変換
            int outputdata = BitConverter.ToUInt16(binarydata, 0);

            return outputdata;
        }
    }
}
