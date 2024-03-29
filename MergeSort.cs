using System;

class Program
{
  const int MAX = 500005;
  const int INF = int.MaxValue;
  static int n;
  static int[] nums = new int[MAX];
  static int cnt = 0;
  static void Main(string[] args)
  {
    try
    {
      n = Convert.ToInt32(Console.ReadLine());
      string[] vs = Console.ReadLine().Split(' ');
      for(int i = 0; i < n; i++)
      {
        nums[i] = Convert.ToInt32(vs[i]);
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }

    MergeSort(nums, 0, n);

    for(int i = 0; i < n; i++)
    {
      if(i != 0)
      {
        Console.Write(' ');
      }
      Console.Write(nums[i]);
    }
    Console.WriteLine("\n{0}", cnt);
  }

  static void Merge(int[] a, int l, int m, int r)
  {
    int n1 = m - l;
    int n2 = r - m;
    int[] left = new int[n1 + 1];
    int[] right = new int[n2 + 1];

    int i;
    for(i = 0; i < n1; i++)
    {
      left[i] = a[l + i];
    }
    for(i = 0; i < n2; i++)
    {
      right[i] = a[m + i];
    }
    left[n1] = INF;
    right[n2] = INF;

    i = 0;
    int j = 0;
    for(int k = l; k < r; k++)
    {
      cnt++;
      if(left[i] <= right[j])
      {
        a[k] = left[i];
        i++;
      }
      else
      {
        a[k] = right[j];
        j++;
      }
    }
  }

  static void MergeSort(int[] a, int l, int r)
  {
    if(l + 1 < r)
    {
      int m = (l + r) / 2;
      MergeSort(a, l, m);
      MergeSort(a, m, r);
      Merge(a, l, m, r);
    }
  }

}