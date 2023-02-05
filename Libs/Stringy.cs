using System.Collections.Generic;
using System.Text;

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
            string valor = string.Empty;
            for (int i = 0; i < strings.Count; i++)
            {
                valor += strings[i];
            }
        }

        public void ConcatenarMaisIgualValorComFor()
        {
            string valor = string.Empty;
            for (int i = 0; i < strings.Count; i++)
            {
                valor += strings[i];
            }
        }

        public void ConcatenarMaisValorComForeach()
        {
            string valor = string.Empty;
            foreach (string item in strings)
            {
                valor += item;
            }
        }

        public void ConcatenarMaisIgualValorComForeach()
        {
            string valor = string.Empty;
            foreach (string item in strings)
            {
                valor += item;
            }
        }

        public void CancatenarStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in strings)
            {
                _ = sb.Append(item);
            }
        }

        public void CancatenarStringConcat()
        {
            string valor = string.Empty;
            foreach (string item in strings)
            {
                valor = string.Concat(valor, item);
            }
        }
    }
}