//O(nlog(n))T | O(1) space
public class Program
{
    public int MinimumWaitingTime(int[] queries)
    {
        // Write your code here.
        Array.Sort(queries);
        int l = queries.Length;
        int s = 0;
        for (int i = 0; i < (l - 1); i++)
        {
            s = queries[i] * (l - i - 1) + s;
        }
        return s;
    }
}

public class Program2
{
    public int MinimumWaitingTime(int[] queries)
    {
        // Write your code here.
        Array.Sort(queries);
        int l = queries.Length;
        int s = 0;
        int aux = 0;
        for (int i = 0; i < (l - 1); i++)
        {
            aux = queries[i] + aux;
            s = aux + s;
        }
        return s;
    }
}

