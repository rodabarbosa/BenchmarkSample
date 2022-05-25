using BenchmarkDotNet.Running;
using BenchmarkTest.Libs;

namespace BenchmarkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<OrderBench>();
            //var summary2 = BenchmarkRunner.Run<StringyBench>();
        }
    }
}
