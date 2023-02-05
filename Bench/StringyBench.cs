using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkTest.Libs;

namespace BenchmarkTest.Bench;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringyBench
{
    private readonly Stringy _stringy = new();

    [Benchmark]
    public void ConcatenarMaisValorComFor()
    {
        _stringy.ConcatenarMaisValorComFor();
    }

    [Benchmark]
    public void ConcatenarMaisIgualValorComFor()
    {
        _stringy.ConcatenarMaisIgualValorComFor();
    }

    [Benchmark]
    public void ConcatenarMaisValorComForeach()
    {
        _stringy.ConcatenarMaisValorComForeach();
    }

    [Benchmark]
    public void ConcatenarMaisIgualValorComForeach()
    {
        _stringy.ConcatenarMaisIgualValorComForeach();
    }

    [Benchmark]
    public void CancatenarStringBuilder()
    {
        _stringy.CancatenarStringBuilder();
    }

    [Benchmark]
    public void CancatenarStringConcat()
    {
        _stringy.CancatenarStringConcat();
    }
}
