using System;

class Program
{
  struct Task
  {
    private string name;
    private int time;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public int Time
    {
      get { return time; }
      set { time = value; }
    }
  }
  const int MAX = 100005;
  static Task[] tasks = new Task[MAX];
  static int head = 0;
  static int tail = 0;
  static int n;
  static int q;
  static void Main(string[] args)
  {
    try
    {
      string[] vs = Console.ReadLine().Split(' ');
      n = Convert.ToInt32(vs[0]);
      q = Convert.ToInt32(vs[1]);
      for(int i = 0; i < n; i++)
      {
        string[] tmp = Console.ReadLine().Split(' ');
        Task tTmp = new Task
        {
          Name = tmp[0],
          Time = Convert.ToInt32(tmp[1])
        };
        Enqueue(tTmp);
      }
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }

    int tmPassed = 0;
    while(head != tail)
    {
      Task tCurrent = Dequeue();
      if(tCurrent.Time - q > 0)
      {
        tmPassed += q;
        tCurrent.Time -= q;
        Enqueue(tCurrent);
      }
      else
      {
        tmPassed += tCurrent.Time;
        Console.WriteLine("{0} {1}", tCurrent.Name, tmPassed);
      }
    }
  }
  
  static void Enqueue(Task t)
  {
    tasks[tail++ % MAX] = t;
  }

  static Task Dequeue()
  {
    return tasks[head++ % MAX];
  }

}