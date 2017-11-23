using System;

class Test
{
  static void Main()
  {
    ForLoop();
    WhileLoop();
    DoWhileLoop();
    ForeachLoop();
  }

  static void ForLoop()
  {
    Console.WriteLine("\nTesting for loop");
    for( int i = 0; i <= 10; i++ ) {
      Console.WriteLine("i = {0}", i);
    }
  }

  static void WhileLoop()
  {
    Console.WriteLine("\nTesting while loop");
    int i = 0;
    while( i < 10 ) {
      Console.WriteLine("i = {0}", i);
      i = i + 2;
    }
  }

  static void DoWhileLoop()
  {
    Console.WriteLine("\nTesting do-while loop");
    int i = 10;
    do {
      Console.WriteLine("i = {0}", i);
      i= i + 1;
    } while( i < 10 );
  }
  
  static void ForeachLoop()
  {
    Console.WriteLine("\nTesting foreach loop");
    string sentence = "This is a sentence";
    foreach( char c in sentence ) {
      Console.WriteLine("c = {0}", c);
    }
  }

}
