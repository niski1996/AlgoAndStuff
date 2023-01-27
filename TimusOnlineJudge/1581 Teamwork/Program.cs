using System;
using System.Globalization;

public class ReverseRoot
{
    private static void Main()
    {
        NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
        string[] input = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r' },StringSplitOptions.RemoveEmptyEntries);
        //int[] input = { 8, 1, 1, 2, 3, 3, 3, 10, 10 };
        string number = input[1];
        short amount=0;
		for (int i = 1; i <= short.Parse(input[0]); i++)
		{
			if (number== input[i])
			{
                amount += 1;
			}
			else
			{
				Console.Write(amount+" "+number + " ");
				number = input[i];
				amount = 1;
			}


		}
		Console.Write(amount + " "+number);

    }
}
