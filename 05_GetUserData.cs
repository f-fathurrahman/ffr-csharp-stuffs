using System;

class Test
{
  static void Main()
  {
    GetUserData();
  }

  static void GetUserData()
  {
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();

    Console.Write("Please enter your age: ");
    int userAge = Convert.ToInt32( Console.ReadLine() );
    // alternative:
    // int userAge = int.Parse( Console.ReadLine() );

    // Change echo color
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
    
    Console.WriteLine("This line will be displayed in yellow");

    Console.ForegroundColor = prevColor;
    
    Console.WriteLine("This line will be displayed in the previous color: {0}", prevColor);
  }
}
