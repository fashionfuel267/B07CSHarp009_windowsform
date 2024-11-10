using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07CSHarp009_w02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            int[] data = new int[] { 10, 8, 6, 4, 2 };
            foreach (int number in data)
            {
                numbers.AddFirst(number);
            }
            foreach (int number in numbers)
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (LinkedListNode<int> node=numbers.First; node!=null; node=node.Next)
            {
                Console.Write($"{node.Value}\t");
            }
            Console.WriteLine(  );
            Console.WriteLine();
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                Console.Write($"{node.Value}\t");
            }
            Console.ReadKey();
        }
    }
} 
