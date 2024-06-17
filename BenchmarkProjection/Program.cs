using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkProjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var summaryArray = BenchmarkRunner.Run<BenchmarkArray>();
            //var summaryString = BenchmarkRunner.Run<NameParserBenchMarks>();
            var summary = BenchmarkRunner.Run<StringBenchMarks>();
            Console.ReadLine();
        }
    }
}
