using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var li = new List<int> { 3, 4, 5, 2, 4, 1, 3 };
            insertSort(li);
            foreach (var item in li)
            {
                Console.WriteLine( item);
            }
            Console.ReadLine();
        }
        public static List<int> insertSort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int borderIndex = 0;
                while (input[i]>input[borderIndex])
                {
                    borderIndex++;
                }
                int tmp = input[i];
                input.RemoveAt(i);
                input.Insert(borderIndex, tmp);
            }
            return input;
        }
    }
}
