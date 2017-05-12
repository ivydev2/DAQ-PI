using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MccDaq;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnalogIn_toStripchart_SW_Timed
{
    public partial class Form1 : Form
    {

        public MccDaq.MccBoard DaqBoard;
        public MccDaq.ErrorInfo ULStat;
        public MccDaq.Range Range;
        public System.Int32 numchannels = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //First Lets make sure there's a USB-1408FS plugged in,
            System.Int16 BoardNum;
            System.Boolean Boardfound = false;
            for (BoardNum = 0; BoardNum < 99; BoardNum++)
            {

                DaqBoard = new MccDaq.MccBoard(BoardNum);
                if (DaqBoard.BoardName.Contains("1408FS"))
                {
                    Boardfound = true;
                    DaqBoard.FlashLED();
                    break;
                }
            }

            if (Boardfound == false)
            {
                System.Windows.Forms.MessageBox.Show("No USB-1408FS found in system.  Please run InstaCal.", "No Board detected");
                this.Close();
            }
            else
            {

                System.String mystring = DaqBoard.BoardName.Substring(0, DaqBoard.BoardName.Trim().Length - 1) +
                " found as board number: " + BoardNum.ToString();
                this.Text = mystring;

                //Initialize objects on the form needing attention
                LoadComboBox(cmboAInRange);

                //Determine if the device is set for single ended or differential by the number of channels.
                //use the value returned to set the NumericUpDown Control
                DaqBoard.BoardConfig.GetNumAdChans(out numchannels);
                nudAInChannel.Maximum = numchannels - 1;

                //set up sample timing
                for (int i = 1; i < 11; i++)
                    cbRate.Items.Add(i);
                cbRate.SelectedIndex = 9;
            }

        }
        public void LoadComboBox(ComboBox sender)
        {
            sender.Items.Add("BIP20VOLTS");
            sender.Items.Add("BIP10VOLTS");
            sender.Items.Add("BIP5VOLTS");
            sender.Items.Add("BIP4VOLTS");
            sender.Items.Add("BIP2PT5VOLTS");
            sender.Items.Add("BIP2VOLTS");
            sender.Items.Add("BIP1PT25VOLTS");
            sender.Items.Add("BIP1VOLTS");
            sender.SelectedIndex = 1;
        }

        public void SelectRange(Int32 ComboBoxIndex)
        {
            switch (ComboBoxIndex)
            {
                case 0:
                    Range =  MccDaq.Range.Bip20Volts;
                    break;
                case 1:
                    Range =  MccDaq.Range.Bip10Volts;
                    break;
                case 2:
                    Range =  MccDaq.Range.Bip5Volts;
                    break;
                case 3:
                    Range = MccDaq.Range.Bip4Volts;
                    break;
                case 4:
                    Range =  MccDaq.Range.Bip2Pt5Volts;
                    break;
                case 5:
                    Range =  MccDaq.Range.Bip2Volts;
                    break;
                case 6:
                    Range =  MccDaq.Range.Bip1Pt25Volts;
                    break;
                case 7:
                    Range =  MccDaq.Range.Bip1Volts;
                    break;
            }
        }
        public void errhandler(MccDaq.ErrorInfo ULStat)
        {
            //Generic UL error handler
            tmrAnalogIn.Enabled = false;
            lblAIMode.Text = "Idle";
            btnStartStop.Text = "Start";
            System.Windows.Forms.MessageBox.Show(ULStat.Message, "Universal Library Error ");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                lblAIMode.Text = "Running";
                btnStartStop.Refresh();
                tmrAnalogIn.Interval = 1000 / Convert.ToInt32(cbRate.SelectedItem);
                stripChart1.TimeInterval = tmrAnalogIn.Interval;
                stripChart1.Reset();                         //reset/clear the stripchart
                tmrAnalogIn.Enabled = true;
            }
            else
            {
                btnStartStop.Text = "Start";
                lblAIMode.Text = "Idle";
                tmrAnalogIn.Enabled = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrAnalogIn_Tick(object sender, EventArgs e)
        {
            //here is how to implement the VIn() Method.
            System.Single VInVolts;

            SelectRange(cmboAInRange.SelectedIndex);

            ULStat = DaqBoard.VIn(Convert.ToInt16(nudAInChannel.Value), Range, out VInVolts, MccDaq.VInOptions.Default);
            if (ULStat.Value != MccDaq.ErrorInfo.ErrorCode.NoErrors)
            {
                errhandler(ULStat);
                return;
            }

            txtADValue.Text = VInVolts.ToString("#0.###");
            stripChart1.AddValue(VInVolts);
           
            chart1.Series[1].Points.Add(VInVolts);
            
           
            
        }

        private void stripChart1_Load(object sender, EventArgs e)
        {

        }

    }
}
