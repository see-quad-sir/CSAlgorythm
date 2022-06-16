using System;

class Program
{
    const int MAX = 105;
    static int n;
    static int[] arr = new int[MAX];
    static int cnt = 0;
    static void Main(string[] args)
    {
        try
        {
            n = Convert.ToInt32(Console.ReadLine());
            var sNum = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(sNum[i]);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Selection(arr);

        for(int i = 0; i < n; i++)
        {
            if(i != 0)
            {
                Console.Write(' ');
            }
            Console.Write(arr[i]);
        }
        Console.WriteLine("\n{0}", cnt);
    }
    static void Selection(int[] a)
    {
        for(int i = 0; i < n; i++)
        {
            int mini = i;
            for(int j = i; j < n; j++)
            {
                if(a[j] < a[mini])
                {
                    mini = j;
                }
            }
            if (i != mini)
            {
                int tmp = a[i];
                a[i] = a[mini];
                a[mini] = tmp;
                cnt++;
            }
        }
    }
}