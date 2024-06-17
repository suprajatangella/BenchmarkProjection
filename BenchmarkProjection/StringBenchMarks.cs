using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkProjection
{
    [MemoryDiagnoser]
    public class StringBenchMarks
    {
        [Params(5, 50, 500)] //<-- This is a parameter attribute
        public int N { get; set; }

        [Benchmark(Baseline = true)] // <-- this is the baseline
        public string StringJoin()
        {
            return string.Join(", ", Enumerable.Range(0, N).Select(i => i.ToString()));
        }
        [Benchmark]
        public string StringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
