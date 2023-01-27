using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//całkowicie złe podejście, wynikające z poznania tylko jednego sposobu generowania. prawidłowe polega na przesunięciach
//bitowych i wykorzystaniu xor

namespace GreyCode
{
	class GreyCodeTable
	{
		private static List<List<int>> BinarySeed = new List<List<int>>
		{
			new List<int>{ 0,0},
			new List<int>{ 0,0},
			new List<int>{ 0,0},
			new List<int>{ 0,0},
		};
		private static int[] DecimalSeed = new int[] { 0, 1, 3, 2 };
		private static List<int> LastDecimal;
		private static List<T> Reflect<T>(List<T> input)
		{
			for (int i = (input.Count - 1); i >=0 ; i--)
			{
				input.Add(input[i]);
			}
			return input;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"> list odf grey parameters after on reflection</param>
		private static List<int> CompleateDecimal(List<int> input)
		{
			int power = (int)Math.Log(input.Count,2)-1;
			for (int i = 0; i < input.Count; i++)
			{
				if (i>input.Count/2-1)
				{
					input[i] = input[i] + (int)Math.Pow(2, power);
				}
			}
			return input;
		}

		public static List<int> DecimalTable(int levels)
		{
			List<int> output = DecimalSeed.ToList<int>();
			for (int i = 0; i < levels; i++)
			{
				output = Reflect(output);
				output = CompleateDecimal(output);
			}
			LastDecimal = output;
			return output;
		}

		public static void ShowLastDecimal() 
		{
			foreach (var item in LastDecimal)
			{
				Console.WriteLine(item);
			}
		}
		public static void ShowLastBinary()
		{
			foreach (var item in LastDecimal)
			{
				Console.WriteLine(Convert.ToString(item,2));
			}
		}
		public static int GiveNext(int target)
		{
			char[] bin = Convert.ToString(target, 2).ToArray();
			int frontSum = 0;
			for (int i = 0; i < bin.Length-2; i++)
			{
				frontSum += bin[i] - '0';

			}
			int flag = frontSum % 2;
			if (flag==0)
			{
				if (target%4==0)
				{
					return target + 1;
				}
				else if (target % 4 == 1)
				{
					return target + 2;
				}
				else if (target % 4 == 3)
				{
					return target - 1;
				}
				else
				{
					return target + (int)Math.Pow(2, bin.Length - 1);
				}
			}
			else
			{
				if (target % 4 == 2)
				{
					return target + 1;
				}
				else if (target % 4 == 3)
				{
					return target - 2;
				}
				else if (target % 4 == 1)
				{
					return target - 1;
				}
				else
				{
					return target + (int)Math.Pow(2, bin.Length - 1);
				}
			}
		}




	}
}
