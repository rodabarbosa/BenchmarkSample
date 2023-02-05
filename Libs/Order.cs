using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTest.Libs
{
    public class Order
    {
        public static List<int> GetListOfInt()
        {
            return new List<int> { 3, 7, 10, 6, 5, 4, 2, 9, 8, 1 };
        }

        public void SortFor()
        {
            List<int> list = GetListOfInt();
            int temp;
            for (var i = 0; i < list.Count - 1; i++)
            {
                for (var j = i + 1; j < list.Count; j++)
                {
                    if (list[i] < list[j])
                        continue;

                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }

        public void SortLinq()
        {
            IEnumerable<int> list = from item in GetListOfInt()
                                    orderby item
                                    select item;
        }

        public void SortLambda()
        {
            List<int> list = GetListOfInt();
            list = list.OrderBy(x => x).ToList();
        }

        public void SortLambda2()
        {
            IEnumerable<int> list = GetListOfInt().OrderBy(x => x);
        }

        public void SortLambda3()
        {
            IEnumerable<int> list = GetListOfInt().AsEnumerable<int>();
            list = list.OrderBy(x => x);
        }

        public void SortLambda4()
        {
            List<int> list = GetListOfInt().ToList();
            var list2 = list.OrderBy(x => x).ToList();
        }

    }
}