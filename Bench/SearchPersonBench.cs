using System;
using System.Collections.Generic;
using Benchmark.Models;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkTest.Libs;

namespace BenchmarkTest.Bench;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SearchPersonBench
{
    private const string searchParam = "Person35";
    private static readonly SearchPerson _searchPerson = new();

    private List<Person> GetPersonList()
    {
        return new List<Person>
        {
            new() { FirstName = "Person0", LastName = "Person0", Email = "Person0@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person1", LastName = "Person1", Email = "Person1@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person2", LastName = "Person2", Email = "Person2@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person3", LastName = "Person3", Email = "Person3@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person4", LastName = "Person4", Email = "Person4@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person5", LastName = "Person5", Email = "Person5@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person6", LastName = "Person6", Email = "Person6@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person7", LastName = "Person7", Email = "Person7@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person8", LastName = "Person8", Email = "Person8@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person9", LastName = "Person9", Email = "Person9@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person10", LastName = "Person10", Email = "Person10@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person11", LastName = "Person11", Email = "Person11@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person12", LastName = "Person12", Email = "Person12@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person13", LastName = "Person13", Email = "Person13@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person14", LastName = "Person14", Email = "Person14@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person15", LastName = "Person15", Email = "Person15@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person16", LastName = "Person16", Email = "Person16@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person17", LastName = "Person17", Email = "Person17@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person18", LastName = "Person18", Email = "Person18@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person19", LastName = "Person19", Email = "Person19@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person20", LastName = "Person20", Email = "Person20@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person21", LastName = "Person21", Email = "Person21@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person22", LastName = "Person22", Email = "Person22@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person23", LastName = "Person23", Email = "Person23@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person24", LastName = "Person24", Email = "Person24@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person25", LastName = "Person25", Email = "Person25@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person26", LastName = "Person26", Email = "Person26@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person27", LastName = "Person27", Email = "Person27@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person28", LastName = "Person28", Email = "Person28@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person29", LastName = "Person29", Email = "Person29@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person30", LastName = "Person30", Email = "Person30@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person31", LastName = "Person31", Email = "Person31@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person32", LastName = "Person32", Email = "Person32@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person33", LastName = "Person33", Email = "Person33@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person34", LastName = "Person34", Email = "Person34@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person35", LastName = "Person35", Email = "Person35@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person36", LastName = "Person36", Email = "Person36@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person37", LastName = "Person37", Email = "Person37@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person38", LastName = "Person38", Email = "Person38@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person39", LastName = "Person39", Email = "Person39@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person40", LastName = "Person40", Email = "Person40@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person41", LastName = "Person41", Email = "Person41@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person42", LastName = "Person42", Email = "Person42@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person43", LastName = "Person43", Email = "Person43@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person44", LastName = "Person44", Email = "Person44@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person45", LastName = "Person45", Email = "Person45@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person46", LastName = "Person46", Email = "Person46@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person47", LastName = "Person47", Email = "Person47@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person48", LastName = "Person48", Email = "Person48@test.com", Birth = DateTime.Now },
            new() { FirstName = "Person49", LastName = "Person49", Email = "Person49@test.com", Birth = DateTime.Now }
        };
    }

    [Benchmark]
    public void GetPersonIndex()
    {
        var persons = GetPersonList();
        _ = _searchPerson.GetPersonIndex(searchParam, persons);
    }

    [Benchmark]
    public void GetPersonIgnoreOrdinaryIndex()
    {
        var persons = GetPersonList();
        _ = _searchPerson.GetPersonIgnoreOrdinaryIndex(searchParam, persons);
    }

    [Benchmark]
    public void GetPersonLowerIndex()
    {
        var persons = GetPersonList();
        _ = _searchPerson.GetPersonLowerIndex(searchParam, persons);
    }

    [Benchmark]
    public void GetPersonLinqIndex()
    {
        var persons = GetPersonList();
        _ = _searchPerson.GetPersonLinqIndex(searchParam, persons);
    }
}
