using System;

class Program
{
  const int MAX = 40;
  static int n;
  struct Cards
  {
    public char suit;
    public int num;
  }
  static Cards[] bCards = new Cards[MAX];
  static Cards[] sCards = new Cards[MAX];

  static void Main(string[] args)
  {
    try
    {
      n = Convert.ToInt32(Console.ReadLine());
      string[] vs = Console.ReadLine().Split(' ');
      for(int i = 0; i < n; i++)
      {
        char[] cTmp = vs[i].ToCharArray();
        bCards[i].suit = sCards[i].suit = cTmp[0];
        bCards[i].num = sCards[i].num = (int)Char.GetNumericValue(cTmp[1]);
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
    }

    Bubble();
    Selection();

    for(int i = 0; i < n; i++)
    {
      if(i != 0)
      {
        Console.Write(' ');
      }
      Console.Write("{0}{1}", bCards[i].suit, bCards[i].num);
    }
    Console.WriteLine("\nStable");

    int flag = 0;
    for(int i = 0; i < n; i++)
    {
      if(i != 0)
      {
        Console.Write(' ');
      }
      Console.Write("{0}{1}", sCards[i].suit, sCards[i].num);
      if(sCards[i].suit != bCards[i].suit)
      {
        flag++;
      }
    }
    if(flag == 0)
    {
      Console.WriteLine("\nStable");
    }
    else
    {
      Console.WriteLine("\nNot stable");
    }
  }

  static void Bubble()
  {
    for(int i = 0; i < n; i++)
    {
      for(int j = n - 1; j >= i + 1; j--)
      {
        if(bCards[j].num < bCards[j - 1].num)
        {
          Cards tmp = bCards[j];
          bCards[j] = bCards[j - 1];
          bCards[j - 1] = tmp;
        }

      }
    }
  }

  static void Selection()
  {
    for(int i = 0; i < n; i++)
    {
      int mini = i;
      for(int j = i; j < n; j++)
      {
        if(sCards[j].num < sCards[mini].num)
        {
          mini = j;
        }
      }
      if (i != mini)
      {
        Cards tmp = sCards[i];
        sCards[i] = sCards[mini];
        sCards[mini] = tmp;
      }
    }
  }
}