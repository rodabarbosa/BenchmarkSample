using BenchmarkDotNet.Running;
using BenchmarkTest.Bench;

namespace BenchmarkTest;

internal static class Program
{
    public static void Main(string[] args)
    {
        //_ = BenchmarkRunner.Run<OrderBench>();
        _ = BenchmarkRunner.Run<SearchPersonBench>();
        //_ = BenchmarkRunner.Run<StringyBench>();
    }
}
