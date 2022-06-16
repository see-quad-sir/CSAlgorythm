using System;

class Program
{
  const int NMAX = 10005;
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
          Linear(vs[i]);
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

  static void Linear(string s)
  {
    for(int i = 0; i < n; i++)
    {
      if(s == nums[i])
      {
        cnt++;
        break;
      }
    }
  }
}