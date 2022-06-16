using System;

class Program
{
  const int MAX = 205;
  static string[] stack = new string[MAX];
  static int top = 0;
  static void Main(string[] args)
  {
    try
    {
      string[] vs = Console.ReadLine().Split(' ');
      foreach(string v in vs)
      {
        Push(v);
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }
    int res = RevPolish();
    while(top != 0)
    {
      res = RevPolish();
    }
    Console.WriteLine(res);
  }
  
  static void Push(string s)
  {
    stack[top++] = s;
  }

  static string Pop()
  {
    return stack[--top];
  }

  static int RevPolish()
  {
    int result = int.MaxValue;
    string s = Pop();
    int[] num = new int[2];
    switch(s)
    {
      case "+":
        num[0] = RevPolish();
        num[1] = RevPolish();
        result = num[1] + num[0];
        break;

      case "-":
        num[0] = RevPolish();
        num[1] = RevPolish();
        result = num[1] - num[0];
        break;

      case "*":
        num[0] = RevPolish();
        num[1] = RevPolish();
        result = num[1] * num[0];
        break;

      default:
        result = Convert.ToInt32(s);
        break;
    }
    return result;
  }
}