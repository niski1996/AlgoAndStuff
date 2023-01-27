using System;

namespace reversPolarity
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputFlag = "01000011010101000100011001111011010000100110100101110100010111110100011001101100011010010111000001110000011010010110111001111101";
			int beg = 0;
			int end = 7;
			try
			{
				while (true)
				{

					Console.WriteLine(inputFlag.Substring(beg, 8));
					beg += 8;
				}


			}
			catch (Exception)
			{

				
			}
			
		}

	}
}
