using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExerSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for cousre A? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                a.Add(m);
            }

            Console.Write("How many students for cousre B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                int m = int.Parse(Console.ReadLine());
                b.Add(m);
            }

            Console.Write("How many students for cousre C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                c.Add(m);
            }

            HashSet<int> all = new HashSet<int>(a);

            all.UnionWith(b);
            all.UnionWith(c);

            Console.WriteLine("Total students:" + all.Count);

        }
    }
}