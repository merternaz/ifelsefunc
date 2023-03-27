using System;
using System.Collections.Generic;


namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;

            string s=a <20 && a>2 ? "aaa" :a>=20 ? "bbb":"ccc";
            Console.WriteLine(s);

        }
    }
}