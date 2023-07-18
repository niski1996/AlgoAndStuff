
public class fullInfo
{
    public List<int> primalDividers;
    public List<int> pfs;
    public HashSet<int> ds;
    public int value;
}
public static class Kata
{
    public static int[] DsMultofPfs(int n1, int n2)
    {
        List<int> primalList = PrimalsBelow(n2);// don't care aout bigger no way that any of them except itself will be divider
        Dictionary<int, fullInfo> divObj = new Dictionary<int, fullInfo>();
        Enumerable.Range(n1, n2 - n1 + 1).Select(k => divObj[k] = divRekur(
            k,
            primalList.Where(i => k % i == 0).ToList(),
            divObj
            )).ToList();

        return divObj.Keys.Where(x => ((divObj[x].ds.Sum() % divObj[x].pfs.Where(x => x != 1).Sum()) == 0)).ToArray();
    }

    private static fullInfo divRekur(int value, List<int> dividers, Dictionary<int, fullInfo> cache)//dividers not include 1
    {

        int tmpDiv = dividers.Last();
        if (dividers.Count() == 1)//co jeżeli zamiast jeden w lście zostanie np.3?
            return new fullInfo
            {
                pfs = new List<int> { value },
                ds = new HashSet<int> { 1, value }
            };
        else if (cache.ContainsKey(value / dividers.Last()))
            return new fullInfo
            {
                pfs = (cache[(value / tmpDiv)]).pfs.Concat(new[] { tmpDiv }).ToList(),
                ds = (cache[(value / tmpDiv)]).ds.Select(s => s * tmpDiv).ToHashSet().Union((cache[(value / tmpDiv)]).ds).ToHashSet()
            };
        else
        {
            fullInfo rekurObj;
            if ((value/tmpDiv)%tmpDiv==0)
            {
                rekurObj = divRekur(value / tmpDiv, dividers, cache);
            }
            else
            {
                rekurObj = divRekur(value / tmpDiv, dividers.GetRange(0, (dividers.Count - 1)), cache);
            }
            
            return new fullInfo
            {

                ds = rekurObj.ds.SelectMany(x => new[] { x, x * tmpDiv }).ToHashSet(),
                pfs = rekurObj.pfs.Concat(new[] { tmpDiv }).ToList(),
            };
        }


    }

    public static List<int> PrimalsBelow(int topLplimit)
    {
        var outLiist = new List<int>() { 1 };
        for (int i = 2; i <= topLplimit; i++)
        {
            bool primFlag = true;
            foreach (int k in outLiist)
            {
                if (k != 1 && i % k == 0)
                {
                    primFlag = false;
                    break;
                }
            }
            if (primFlag)
            {
                outLiist.Add(i);
            }
        }
        return outLiist;
    }
}



