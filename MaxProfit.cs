using System;

class Program
{
    const int MAX = 200005;
    static int n;
    static int res;
    static void Main(string[] args)
    {
        Input();
        res = MaxProfit();
        Output();
    }

    static void Input()
    {
        try
        {
            n = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void Output()
    {
        Console.WriteLine(res);
    }

    static int MaxProfit()
    {
        int[] ccy = new int[MAX];
        int maxPt = int.MinValue;
        int iMax = int.MinValue;
        for(int i = 0; i < n; i++)
        {
            try
            {
                ccy[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        for(int i = n - 1; i >= 1; i--)
        {
            if(ccy[i] < iMax)
            {
                continue;
            }
            int jMin = int.MaxValue;
            for(int j = i - 1; j >= 0; j--)
            {
                if(ccy[j] > jMin)
                {
                    continue;
                }
                else if(ccy[i] - ccy[j] > maxPt)
                {
                    maxPt = ccy[i] - ccy[j];
                    iMax = ccy[i];
                    jMin = ccy[j];
                }
            }
        }
        return maxPt;
    }
}