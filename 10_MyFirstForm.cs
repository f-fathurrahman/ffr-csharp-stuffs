using System;
using System.Windows.Forms;

class MyFirstApp
{
  static void Main() {
    Form form = new MyFirstForm();
    Application.Run(form);
  }
}

class MyFirstForm : Form 
{
  public MyFirstForm()
  {
    this.Text = "Hello WinForms from ffr";
    Button button = new Button();
    button.Text = "Click Me!";
    // event-handler
    button.Click += new EventHandler(button_Click);
    // add the button
    this.Controls.Add(button);
  }

  void button_Click(object sender, EventArgs e)
  {
    Console.WriteLine("button_Click is executed");
    
    MessageBox.Show("Well you click this button ...");
    
    // this will not appear if OK button in MessageBox is not clicked yet
    Console.WriteLine("In button_Click after OK in MessageBox"); 
  }
}
