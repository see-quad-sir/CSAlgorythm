using System;

class Insertion
{
    static void Main(string[] args)
    {
        int n = 0;
        string[] num;
        int[] arr;
        try
        {
            n = Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        finally
        {
            arr = new int[n];
        }

        num = Console.ReadLine().Split(' ');

        for(int i = 0; i < n; i++)
        {
            try
            {
                arr[i] = Convert.ToInt32(num[i]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        PrintArr(arr, n);
        InsertionSort(arr, n);
    }

    static void InsertionSort(int[] a, int n)
    {
        for (int i = 1; i < n; i++)
        {
            int key = a[i];
            int j = i - 1;
            while (j >= 0 && a[j] > key)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = key;
            PrintArr(a, n);
        }
    }

    static void PrintArr(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write(a[i]);
            }
            else
            {
                Console.Write(" " + a[i]);
            }
        }
        Console.WriteLine();
    }
}