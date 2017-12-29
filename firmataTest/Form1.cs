using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace firmataTest
{
  public partial class Form1 : Form
  {
    Firmata arduinoInterface;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      arduinoInterface = new Firmata("com85", 57600, true, 1000);
      arduinoInterface.pinMode(13, Firmata.OUTPUT);
      arduinoInterface.pinMode(9, Firmata.SERVO);
      arduinoInterface.pinMode(11, Firmata.SERVO);
      arduinoInterface.analogWrite(9, trackBar1.Value);
      arduinoInterface.analogWrite(11, trackBar1.Value);

    }

    private void button2_Click(object sender, EventArgs e)
    {
      arduinoInterface.digitalWrite(13, Firmata.HIGH);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      arduinoInterface.digitalWrite(13, Firmata.LOW);
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      arduinoInterface.analogWrite(9, trackBar1.Value);
      arduinoInterface.analogWrite(11, trackBar1.Value);
      label1.Text = trackBar1.Value.ToString();
      
    }
  }
}
