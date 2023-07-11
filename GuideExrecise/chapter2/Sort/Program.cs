using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var li = new List<int> { 3, 4, 5, 1, 4, 2, 3 };
            QuickSort(li);
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
        public static List<int> BubbleSort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
				for (int k = 0; k < i; k++)
				{
					if (input[i-k]<input[i-k-1])
					{
                        (input[i - k], input[i - k - 1]) = (input[i - k - 1], input[i - k]);
                    }
					else
					{
                        break;
					}
				}
            }
            return input;
        }
        public static List<int> QuickSort(List<int> input, int beg=0,int? end=null)
        {
            int pivotIndex = beg;
            end=end ?? input.Count-1;
            if (end-beg+1>1)
            {

                for (int i = beg+1; i <= end; i++)
                {
                    if (input[pivotIndex] > input[i])
                    {
                        input.Insert(beg, input[i]);
                        input.RemoveAt(i + 1);
                        pivotIndex++;
                    }

                }
                QuickSort(input, beg, pivotIndex - 1);
                QuickSort(input, pivotIndex + 1, end);
                return input;

            }
			else
			{
                return input;
			}
        }

    }
}
