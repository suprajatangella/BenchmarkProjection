using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkProjection
{
    [MemoryDiagnoser]
    public class BenchmarkArray
    {
        private int[] data;
        int ArraySize = 2;

        [GlobalSetup]
        public void DataSetup()
        {
            //data[1000]=[0,1,2,....999]
            data = Enumerable.Range(0, ArraySize).ToArray();
        }
        [Benchmark]
        // [1,2,3,4...999] => [1*1,2*2,3*3,4*4,....999*999] = [1,4,9,16,...,998001]
        public int[] SquareForLoop()
        {
            var result = new int[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                result[i] = data[i] * data[i];
            }
            return result;
        }

        [Benchmark]
        public int[] SquareLinq()
        {
            return data.Select(x => x * x).ToArray();
        }

    }
}
