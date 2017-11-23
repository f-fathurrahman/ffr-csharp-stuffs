using System;

class Test
{
  static void Main()
  {
    string userMessage = string.Format("9999 in hex is {0:x}", 9999);
    System.Windows.Forms.MessageBox.Show(userMessage);
  }
}
