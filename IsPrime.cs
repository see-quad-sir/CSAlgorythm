using System;

class Program
{
    static int n;
    static int res;
    static void Main(string[] args)
    {
        Input();
        res = PrimeCheck();
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

    static int PrimeCheck()
    {
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if(x == 2)
                {
                    cnt++;
                }
                else if(x < 2 || x % 2 == 0)
                {
                    continue;
                }
                else if(x > 2 && x % 2 == 1)
                {
                    int j;
                    for(j = 3; j <= Math.Sqrt(x); j += 2)
                    {
                        if (x % j == 0) break;
                    }
                    if(j > Math.Sqrt(x))
                    {
                        cnt++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -999;
            }
        }
        return cnt;
    }
}