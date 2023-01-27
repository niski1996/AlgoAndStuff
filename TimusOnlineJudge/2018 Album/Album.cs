using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoStuff
{
    internal class Album
    {
       private static void Main()
        {

            ulong t = GoGoDols("3 2 1");//4
            ulong g = GoGoDols("24124 131 232");//373638552
            ulong h = GoGoDols("4 2 1");//5
            ulong q = GoGoDols("15 7 7");
            ulong p = GoGoDols("8 9 9");
            //ulong pe = GoGoDols("3 2 1");
            //NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            //string input = Console.In.ReadToEnd();
            //ulong output = GoGoDols(input);
            //Console.WriteLine(output);


        }
        public static ulong  GoGoDols(string input)
        {
            int[] listOfInput = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
            ulong[][] buckets =
                {
                new ulong[listOfInput[1]],
                new ulong[listOfInput[2]]
            };
            buckets[0][0] = 1;
            buckets[1][0] = 1;
            for (int i = 1; i < listOfInput[0]; i++)
            {
                ulong BuforOne = 0;
                ulong BuforTwo = 0;
                BuforOne += buckets[0].Last();
                for (int k = buckets[0].Length - 2; k >= 0; k--)
                {
                    buckets[0][k+1]=buckets[0][k];
                    BuforOne += buckets[0][k + 1];

                }
                BuforTwo += buckets[1].Last();
                for (int j = buckets[1].Length - 2; j >= 0; j--)
                {
                    buckets[1][j + 1] = buckets[1][j];
                    BuforTwo += buckets[1][j + 1];

                }
                buckets[0][0] = BuforTwo;
                buckets[1][0] = BuforOne;

            }
            ulong result = 0;
            foreach (var bucket in buckets)
            {
                foreach (var item in bucket)
                {
                    result += item;
                }

            }
            return (ulong)(result);
        }

        static int a, b;
        public static ulong GoGoDols2(string input)
        {
            int[] nab = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();


            a = nab[1] > nab[2] ? nab[2] : nab[1];
            b = nab[1] < nab[2] ? nab[2] : nab[1];
        }

        private static int trek(int i) 
        {
            if (i == 0) return 1;
            else if (0 < i&&i <= a)
                return (int)Math.Pow(2,i)
        }
    else if (0 < i <= a)
        return 2 * *i
    elif a<i <= b:
        return 2 * trek(i - 1) - 1


if nab[0] <= b:
    con = trek(nab[0])
    print(con % (10 * *9 + 7))
else:
    con = trek(b)
    k = nab[0] - b
    print((2 * *k * con - 2 * (2 * *k - 1)) % (10 * *9 + 7))



    }
}
