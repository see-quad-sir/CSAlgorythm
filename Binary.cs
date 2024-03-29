using System;

class Program
{
  const int NMAX = 100005;
  static int n;
  static string[] nums = new string[NMAX];
  static int cnt = 0;
  static void Main(string[] args)
  {
    try
    {
      n = Convert.ToInt32(Console.ReadLine());
      nums = Console.ReadLine().Split(' ');
      int q = Convert.ToInt32(Console.ReadLine());
      string[] vs = Console.ReadLine().Split(' ');
      {
        for(int i = 0; i < q; i++)
        {
          Binary(vs[i], 0, n);
        }
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }

    Console.WriteLine(cnt);
  }

  static void Binary(string s, int l, int r)
  {
    int m = (l + r) / 2;
    if(s == nums[m])
    {
      cnt++;
      return;
    }
    else if(l == m)
    {
      return;
    }
    else if(Convert.ToInt32(nums[m]) > Convert.ToInt32(s))
    {
      Binary(s, l, m);
    }
    else
    {
      Binary(s, m, r);
    }
  }
}