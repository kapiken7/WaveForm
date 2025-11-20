using System;
using System.Diagnostics;

namespace WaveForm
{
    internal class DataGenerator
    {
        // 乱数生成用
        private static readonly Random random = new Random();

        // 2バイト分の配列作成
        byte[] binaryData = new byte[2];

        public DataGenerator(){}

        public int GenerateValue()
        {
            // バイナリデータの乱数作成
            random.NextBytes(binaryData);

            // 10進数に変換(0～65535)
            int outputData = BitConverter.ToUInt16(binaryData, 0);

            return outputData;
        }
    }
}