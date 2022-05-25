using System.Runtime.CompilerServices;
using System.Text;
using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTest.Libs
{
    public class Stringy
    {
        private readonly List<string> strings = new List<string>
        {
            "TESTE1",
            "TESTE2",
            "TESTE3",
            "TESTE4",
            "TESTE5",
            "TESTE6",
            "TESTE7",
            "TESTE8",
            "TESTE9",
            "TESTE10"
        };

        public void ConcatenarMaisValorComFor()
        {
            var valor = string.Empty;
            for (int i = 0; i < strings.Count; i++)
            {
                valor = valor + strings[i];
            }
        }

        public void ConcatenarMaisIgualValorComFor()
        {
            var valor = string.Empty;
            for (int i = 0; i < strings.Count; i++)
            {
                valor = valor + strings[i];
            }
        }

        public void ConcatenarMaisValorComForeach()
        {
            var valor = string.Empty;
            foreach (var item in strings)
            {
                valor = valor + item;
            }
        }

        public void ConcatenarMaisIgualValorComForeach()
        {
            var valor = string.Empty;
            foreach (var item in strings)
            {
                valor += item;
            }
        }

        public void CancatenarStringBuilder()
        {
            var sb = new StringBuilder();
            foreach (var item in strings)
            {
                sb.Append(item);
            }
        }

        public void CancatenarStringConcat()
        {
            var valor = string.Empty;
            foreach (var item in strings)
            {
                valor = string.Concat(valor, item);
            }
        }
    }


    [RPlotExporter]
    [MemoryDiagnoser]
    public class StringyBench
    {
        private readonly Stringy _stringy = new Stringy();

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
}