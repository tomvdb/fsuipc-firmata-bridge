using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using FSUIPC;

namespace firmataTest
{
  public partial class Form1 : Form
  {
    // fsuipc offsets 
    // turn coordinator
    private Offset<short> turn_Rate = new Offset<short>(0x037C);  
    private Offset<sbyte> turn_ballPosition = new Offset<sbyte>(0x36E);
    private Offset<UInt32> speedo_TAS = new Offset<uint>(0x02B8);


    Firmata arduinoInterface;

    bool bridgeRunning = false;

    private void openFSUIPC()
    {
      try
      {
        FSUIPCConnection.Open();
        bridgeTimer.Interval = 200;
        bridgeTimer.Enabled = true;
      }
      catch (Exception ex)
      {
        // Badness occurred - show the error message
        MessageBox.Show(ex.Message, "Bridge Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        FSUIPCConnection.Close();
      }
    }


    public Form1()
    {
      InitializeComponent();

      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      string version = fvi.FileVersion;

      toolStripStatusLabel1.Text = "FSUIPC - Firmata Bridge Version " + version;
      label26.Text = "FSUIPC - Firmata Bridge Version";

      // get list of serial ports
      string[] ports = Firmata.list();

      firmataPortsSelection.Items.Clear();

      for (int c = 0; c < ports.Length; c++ )
      {
        firmataPortsSelection.Items.Add(ports[c]);
      }

      openFSUIPC();

    }

    long map(long x, long in_min, long in_max, long out_min, long out_max)
    {
      return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }

    private void disableControls()
    {
      turnRatePinNr.Enabled = false;
      turnBallPosPinNr.Enabled = false;
      turnCoordinatorTurnRateEnabled.Enabled = false;
      turnCoordinatorBallPosEnabled.Enabled = false;
      TASpinnr.Enabled = false;
      TASEnabled.Enabled = false;
    }

    private void enableControls()
    {
      turnRatePinNr.Enabled = true;
      turnBallPosPinNr.Enabled = true;
      turnCoordinatorTurnRateEnabled.Enabled = true;
      turnCoordinatorBallPosEnabled.Enabled = true;
      TASpinnr.Enabled = true;
      TASEnabled.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (bridgeRunning)
        return;

      if ( firmataPortsSelection.SelectedIndex < 0 )
      {
        MessageBox.Show("You need to select a serial port before you can start bridge");
        bridgeRunning = false;
        return;
      }

      disableControls();

      string serialPortName = firmataPortsSelection.SelectedItem.ToString();

      try
      {

        arduinoInterface = new Firmata(serialPortName, 57600, true, 1000);

        // setup test led
        arduinoInterface.pinMode(13, Firmata.OUTPUT);

        if (turnCoordinatorTurnRateEnabled.Checked)
        {
          arduinoInterface.pinMode(Convert.ToInt32(turnRatePinNr.Value), Firmata.SERVO);
          arduinoInterface.analogWrite(Convert.ToInt32(turnRatePinNr.Value), 90);
        }

        if (TASEnabled.Checked)
        {
          arduinoInterface.pinMode(Convert.ToInt32(TASpinnr), Firmata.SERVO);
          arduinoInterface.analogWrite(Convert.ToInt32(TASpinnr), 0);
        }

        if ( turnCoordinatorBallPosEnabled.Checked)
        {
          arduinoInterface.pinMode(Convert.ToInt32(turnBallPosPinNr.Value), Firmata.SERVO);
          arduinoInterface.analogWrite(Convert.ToInt32(turnBallPosPinNr.Value), 90);
        }

        bridgeRunning = true;

        startStopLabel.Text = "Running";
        startStopLabel.ForeColor = Color.Green;

      }
      catch ( Exception Ex )
      {
        startStopLabel.Text = "Stopped";
        startStopLabel.ForeColor = Color.Red;
        MessageBox.Show("Start Bridge Error: " + Ex.Message);
        bridgeRunning = false;
        enableControls();
      }


    }

    private void button4_Click(object sender, EventArgs e)
    {
      try
      {
        startStopLabel.Text = "Stopped";
        startStopLabel.ForeColor = Color.Red;
        bridgeRunning = false;
        enableControls();
        arduinoInterface.Close();        
      }
      catch ( Exception Ex )
      {
      }
    }



    private void bridgeTimer_Tick(object sender, EventArgs e)
    {
      try
      {
        FSUIPCConnection.Process();

        turnRateValueLabel.Text = turn_Rate.Value.ToString();
        turnBallPosValueLabel.Text = turn_ballPosition.Value.ToString();
        TASValueLabel.Text = (speedo_TAS.Value/128).ToString();

        short modTASValue = -1;

        try
        {
          modTASValue = Convert.ToInt16(map((speedo_TAS.Value/128), Convert.ToInt64(TASMapInputMinText.Text), Convert.ToInt64(TASMapInputMaxText.Text), Convert.ToInt64(TASMapOutputMinText.Text), Convert.ToInt64(TASMapOutputMaxText.Text)));
          TASModValueLabel.Text = modTASValue.ToString();
        }
        catch (Exception Ex)
        {
          TASModValueLabel.Text = "Error";
        }


        short modTurnRateValue = -1;

        try
        {
          modTurnRateValue = Convert.ToInt16(map(turn_Rate.Value, Convert.ToInt64(turnRateMapInputMinText.Text), Convert.ToInt64(turnRateMapInputMaxText.Text), Convert.ToInt64(turnRateMapOutputMinText.Text), Convert.ToInt64(turnRateMapOutputMaxText.Text)));
          turnRateModifiedValueLabel.Text = modTurnRateValue.ToString();
        }
        catch ( Exception Ex )
        {
          turnRateModifiedValueLabel.Text = "Error";
        }

        short modBallPositionValue = -1;

        try
        {
          modBallPositionValue = Convert.ToInt16(map(turn_ballPosition.Value, Convert.ToInt64(turnBallPosMapInputMinText.Text), Convert.ToInt64(turnBallPosMapInputMaxText.Text), Convert.ToInt64(turnBallPosMapOutputMinText.Text), Convert.ToInt64(turnBallPosMapOutputMaxText.Text)));
          turnBallPosModifiedValueLabel.Text = modBallPositionValue.ToString();
        }
        catch (Exception Ex)
        {
          turnBallPosModifiedValueLabel.Text = "Error";
        }

        // if bridgeRunning then send values to arduino/firmata
        if ( bridgeRunning )
        {
          if (TASEnabled.Checked && modTASValue > -1)
          {
            arduinoInterface.analogWrite(Convert.ToInt32(TASpinnr.Value), modTASValue);
          }

          if ( turnCoordinatorTurnRateEnabled.Checked && modTurnRateValue > -1 )
          {
            arduinoInterface.analogWrite(Convert.ToInt32(turnRatePinNr.Value), modTurnRateValue);
          }

          if (turnCoordinatorBallPosEnabled.Checked && modBallPositionValue > -1)
          {
            arduinoInterface.analogWrite(Convert.ToInt32(turnBallPosPinNr.Value), modBallPositionValue);
          }

        }

      }
      catch (FSUIPCException ex)
      {
        if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_SENDMSG)
        {
          this.bridgeTimer.Enabled = false;
          FSUIPCConnection.Close();
          MessageBox.Show("The connection to Flight Sim has been lost.", "Firmata Bridge", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          throw ex;
        }
      }
      catch (Exception)
      {
      }
    }


    private void button2_Click(object sender, EventArgs e)
    {
      arduinoInterface.digitalWrite(13, Firmata.HIGH);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      arduinoInterface.digitalWrite(13, Firmata.LOW);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


  }
}
