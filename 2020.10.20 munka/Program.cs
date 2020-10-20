using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._10._20_munka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[10];

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(r.Next(10, 100));
            }
            Console.ReadKey();
        }
    }
}
