using System;

class Test
{
  static void Main()
  {
    FormatNumericalData();
  }

  static void FormatNumericalData()
  {
    const int VAL_1 = 77777;
    Console.WriteLine("Value of {0} in various format", VAL_1);
    Console.WriteLine("c  format: {0:c}", VAL_1); // currency
    Console.WriteLine("d9 format: {0:d9}", VAL_1);
    Console.WriteLine("f3 format: {0:f3}", VAL_1);
    Console.WriteLine("n  format: {0:n}", VAL_1); // basic numerical formatting

    Console.WriteLine("E  format: {0:E}", VAL_1);
    Console.WriteLine("e  format: {0:e}", VAL_1);
    Console.WriteLine("X  format: {0:X}", VAL_1);
    Console.WriteLine("x  format: {0:x}", VAL_1);
  }
}
