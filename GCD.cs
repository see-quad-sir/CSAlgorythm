using System;

class GreatestCommonDivider
{
    static int a, b;
    static int res;
    static void Main(string[] args)
    {
        Input();
        res = GCD(a, b);
        Output();
    }

    static void Input()
    {
        try
        {
            var num = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(num[0]);
            b = Convert.ToInt32(num[1]);
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

    static int GCD(int x, int y)
    {
        try
        {
            int r = x % y;
            while (r != 0)
            {
                x = y;
                y = r;
                r = x % y;
            }
            return y;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return -999;
        }
    }
}