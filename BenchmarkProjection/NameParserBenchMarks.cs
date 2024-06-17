using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkProjection
{
    [MemoryDiagnoser]
    public class NameParserBenchMarks
    {
        public const string FullName = "Henrik Fexeus";
        private static readonly NameParser parser = new NameParser();

        [Benchmark(Baseline = true)]
        public void GetLastName()
        {
            parser.GetLastName(FullName);
        }
    }
}
