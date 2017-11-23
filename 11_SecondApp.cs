using System;
using System.Windows.Forms;

namespace MySecondApp {
  
public class Form1 : System.Windows.Forms.Form {
  
  public Form1()
  {
    // the following is adapted from generated-code
    Button button1 = new System.Windows.Forms.Button();
    this.SuspendLayout();

    button1.Location = new System.Drawing.Point(96, 72);
    button1.Name = "button1";
    button1.TabIndex = 0;
    button1.Text = "button1";

    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
    this.ClientSize = new System.Drawing.Size(292, 266);
    this.Controls.AddRange(
        new System.Windows.Forms.Control[] {button1});
    this.Name = "Form1";
    this.Text = "Form1";
    this.ResumeLayout(false);
  }
  
  static void Main() {
    Application.Run(new Form1());
  }
}

} // end of package

