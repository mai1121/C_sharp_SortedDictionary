using System;
using System.Collections.Generic;

namespace practice_SortedDictionary
{
    class Program
    {
        //文字列長の短い順に管理する
        public class reserve_sort : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length - y.Length;
            }
        }

        static void Main(string[] args)
        {
            //keyについて辞書順で管理される
            var sd = new SortedDictionary<string, string>()
            {
                {"よしかわ","りんご"},
                {"さとう","みかん"},
                {"はら","ぶどう"},
                {"おおたに","メロン"}
            };
            foreach (var i in sd)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }

            var sd_reverse = new SortedDictionary<string, string>(new reserve_sort())
            {
                 {"よしかわ","りんご"},
                {"さとう","みかん"},
                {"はら","ぶどう"}
                //{"おおたに","メロン"}

            };
            foreach (var i in sd_reverse)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }
        }
    }
}
