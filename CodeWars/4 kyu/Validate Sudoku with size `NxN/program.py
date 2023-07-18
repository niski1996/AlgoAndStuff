using System;
using System.Collections.Generic;
using System.Linq;

class Sudoku
{
    public int[][] sudokuData;
    public Sudoku(int[][] sudokuData)
    {
        this.sudokuData = sudokuData;
    }

    public bool IsValid()
    {
        if ((Math.Sqrt(sudokuData.Length) % 1) != 0) return false;
        Dictionary<string, List<int>> smallArrs = new();
        for (int i = 0; i < sudokuData.Length; i++)
        {
            if (sudokuData.Length != sudokuData[i].Length) return false;             
            for (int f = 0; f < sudokuData[i].Length; f++)
            {
                string myKey = "" + i / (int)Math.Sqrt(sudokuData[i].Length) + "-" + f / (int)Math.Sqrt(sudokuData[i].Length);
                if (smallArrs.ContainsKey(myKey))
                {
                    smallArrs[myKey].Add(sudokuData[i][f]);
                }
                else
                {
                    smallArrs[myKey] = new List<int> { sudokuData[i][f] };
                }
            }
        }
        var rows1 = sudokuData.Select(x => chekIfValid(x.Count(), x)).ToList();
        for (int i = 0; i < sudokuData.Length; i++)
        {
            for (int k = i; k < sudokuData[i].Length; k++)
            {
                (sudokuData[i][k], sudokuData[k][i]) = (sudokuData[k][i], sudokuData[i][k]);
            }
        }
        var rows2 = sudokuData.Select(x => chekIfValid(x.Count(), x)).ToList();
        var rows3 = smallArrs.Keys.Select(x => smallArrs[x]).Select(x => chekIfValid(x.Count(), x.ToArray())).ToList();
        return (!rows1.Contains(false) == true && !rows2.Contains(false) == true && !rows3.Contains(false) == true);
    }
    private bool chekIfValid(int TopLimit, int[] testedArray)
    {
        var tmp = testedArray.ToHashSet();
        if (tmp.Count != testedArray.Count()|| tmp.Max() > TopLimit || tmp.Min() < 0)
        {
            return false;
        }
        else return true;
    }
}
