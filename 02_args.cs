using System;

class Test
{
  static void Main(string[] args)
  {
    foreach(string arg in args) {
      Console.WriteLine("Argument: {0}", arg);
    } 
  }
}
