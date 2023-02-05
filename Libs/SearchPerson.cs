using System;
using System.Collections.Generic;
using Benchmark.Models;

namespace BenchmarkTest.Libs;

public class SearchPerson
{
    public int GetPersonIndex(string name, List<Person> persons)
    {
        var index = 0;
        foreach (var item in persons)
        {
            if (item.FirstName.Equals(name))
                return index;

            index++;
        }

        return -1;
    }

    public int GetPersonIgnoreOrdinaryIndex(string name, List<Person> persons)
    {
        var index = 0;
        foreach (var item in persons)
        {
            if (item.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return index;

            index++;
        }

        return -1;
    }

    public int GetPersonLowerIndex(string name, List<Person> persons)
    {
        var index = 0;
        var nameaux = name.ToLower();
        foreach (var item in persons)
        {
            if (item.FirstName.ToLower().Equals(nameaux))
                return index;

            index++;
        }

        return -1;
    }

    public int GetPersonLinqIndex(string name, List<Person> persons)
    {
        var person = persons.Find(p => p.FirstName.Equals(name));
        return persons.IndexOf(person);
    }
}
