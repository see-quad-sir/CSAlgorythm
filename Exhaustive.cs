using System;

class Program
{
  const int MAX = 25;
  static int n;
  static int[] nums = new int[MAX];
  static int check = 0;
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
      int q = Convert.ToInt32(Console.ReadLine());
      string[] vs1 = Console.ReadLine().Split(' ');
      {
        for(int i = 0; i < q; i++)
        {
          Exhaustive(Convert.ToInt32(vs1[i]), 0);
          if(check == 0)
          {
            Console.WriteLine("no");
          }
          else
          {
            Console.WriteLine("yes");
          }
          check = 0;
        }
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }
  }

  static void Exhaustive(int sum, int a)
  {
    if(sum == 0)
    {
      check++;
      return;
    }
    else if(a == n)
    {
      return;
    }
    else
    {
      Exhaustive(sum, a + 1);
      Exhaustive(sum - nums[a], a + 1);
    }
  }

}