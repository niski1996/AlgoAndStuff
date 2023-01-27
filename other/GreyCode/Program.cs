using System;

namespace GreyCode
{
	class Program
	{
		static void Main(string[] args)
		{
			var tmp = GreyCodeTable.DecimalTable(2);
			GreyCodeTable.ShowLastDecimal();

			Console.WriteLine( GreyCodeTable.GiveNext(1));
		}
	}
}
