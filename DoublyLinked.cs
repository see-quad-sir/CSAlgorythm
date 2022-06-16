using System;

class Program
{
  class List
  {
    private int num;
    private List prev;
    private List next;

    public List(int num)
    {
      this.num = num;
    }
    public int Num
    {
      get { return num; }
    }
    public List Prev
    {
      get { return prev; }
      set { prev = value; }
    }
    public List Next
    {
      get { return next; }
      set { next = value; }
    }
  }
  static List head = new List(-1);
  static int n;
  static int cnt = 0;
  static void Main(string[] args)
  {
    head.Prev = head;
    head.Next = head;
    try
    {
      n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++)
      {
        string[] cmd = Console.ReadLine().Split(' ');
        switch(cmd[0])
        {
          case "insert":
            Insert(cmd[1]);
            break;

          case "delete":
            Delete(cmd[1]);
            break;

          case "deleteFirst":
            DeleteF();
            break;

          case "deleteLast":
            DeleteL();
            break;

          default:
            Console.WriteLine("cmd error");
            throw new Exception();
        }
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }

    List list = head;
    for(int i = 0; i < cnt; i++)
    {
      if(i != 0)
      {
        Console.Write(' ');
      }
      Console.Write(list.Next.Num);
      list = list.Next;
    }
    Console.WriteLine();
  }
  
  static void Insert(string s)
  {
    int num = Convert.ToInt32(s);
    List list = new List(num);
    list.Prev = head;
    list.Next = head.Next;
    head.Next = list;
    list.Next.Prev = list;
    cnt++;
  }

  static void Delete(string s)
  {
    List del = Find(s);
    if(del.Next != head)
    {
      del.Next = del.Next.Next;
      del.Next.Prev = del;
      cnt--;
    }
  }

  static List Find(string s)
  {
    List target;
    for(target = head; target.Next != head; target = target.Next)
    {
      if(target.Next.Num == Convert.ToInt32(s))
      {
        break;
      }
    }
    return target;
  }

  static void DeleteF()
  {
    head.Next = head.Next.Next;
    head.Next.Prev = head;
    if(cnt != 0)
    {
      cnt--;
    }
  }

  static void DeleteL()
  {
    head.Prev = head.Prev.Prev;
    head.Prev.Next = head;
    if(cnt != 0)
    {
      cnt--;
    }
  }

}