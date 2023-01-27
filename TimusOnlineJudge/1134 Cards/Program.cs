using System;
using System.Globalization;
using System.Linq;

public class Cards
{
	private static void Main()
	{
		NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
		string input = Console.In.ReadToEnd();
		Console.WriteLine(Cards.YouAreJokeNick(input));
	}
	public static string YouAreJokeNick(string inputData)
	{
		NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
		short[] unsortedInput = inputData.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(short.Parse)?.ToArray();
		short[] occurences = new short[unsortedInput[0] + 1];//add one on beginning and one in the end to unify;
		for (int i = 2; i < unsortedInput.Length; i++)
		{
			occurences[unsortedInput[i]] += 1;
		}
		int flagOfTwo = 0;
		foreach (var num in occurences)
		{
			if (num == 0)
			{
				flagOfTwo = 1;
			}
			else if (num == 2)
			{
				if (flagOfTwo == 1)
				{
					flagOfTwo = 0;
				}
				else
				{
					return "NO";
				}
			}
			else if (num > 2)
			{
				return "NO";
			}

		}
		Array.Reverse(occurences);
		foreach (var num in occurences)
		{
			if (num == 0)
			{
				flagOfTwo = 1;
				break;
			}
			else if (num == 2)
			{
				if (flagOfTwo == 1)
				{
					flagOfTwo = 0;
				}
				else
				{
					return "NO";
				}
			}

		}
		if (occurences[0] == 2 | occurences[occurences.Length - 1] == 2)
		{
			return "NO";
		}
		return "YES";
	}

}