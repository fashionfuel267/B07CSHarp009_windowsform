using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07CSHarp009_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings=new List<string>();
            strings.Add("Lab1");
            strings.Add("Lab2");
            strings.Add("Lab3");
            strings.Add("Lab4");
            strings.Insert(2, "Extra");
            foreach (string s in strings) { 
                Console.Write($"{s}\t");
            }
            Console.WriteLine();

            //linkedlist


            Console.ReadKey();
        }
    }
}
