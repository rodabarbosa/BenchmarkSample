using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTest.Libs;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class OrderBench
{
    private readonly Order _order = new();

    [Benchmark]
    public void SortFor()
    {
        _order.SortFor();
    }

    [Benchmark]
    public void SortLinq()
    {
        _order.SortLinq();
    }

    [Benchmark]
    public void SortLambda()
    {
        _order.SortLambda();
    }
    /*
   [Benchmark]
   public void SortLambda2() => _order.SortLambda2();

   [Benchmark]
   public void SortLambda3() => _order.SortLambda3();

   [Benchmark]
   public void SortLambda4() => _order.SortLambda4();
*/
}
