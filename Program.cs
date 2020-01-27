using System;

namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      StoreController sc = new StoreController();
      sc.Run();
    }
  }
}
