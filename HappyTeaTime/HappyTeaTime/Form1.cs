using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HappyTeaTime
{
    public partial class Form1 : Form
    {
        public string dataIN;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CboxCOMPORT.Items.AddRange(ports);

            BtnEnter.Enabled = false;
            TboxID.Enabled = false;
            TboxPassword.Enabled = false;
        }

        public void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CboxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CboxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CboxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CboxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CboxPARITYBITS.Text);

                //serialPort1.Open();
                progressBar1.Value = 100;

                BtnEnter.Enabled = true;
                TboxID.Enabled = true;
                TboxPassword.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class SPortdata
        {
            static public string Portname;
            static public string Baudrate;
            static public string DataBits;
            static public string StopBits;
            static public string ParityBit;
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by TKM", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            this.doSomething();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TboxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void doSomething()
        {
            if (TboxID.Text == "happyteatime")
            {
                if (TboxPassword.Text == "12345679")
                {
                    SPortdata.Portname = CboxCOMPORT.Text;
                    SPortdata.Baudrate = CboxBAUDRATE.Text;
                    SPortdata.DataBits = CboxDATABITS.Text;
                    SPortdata.StopBits = CboxSTOPBITS.Text;
                    SPortdata.ParityBit = CboxPARITYBITS.Text;
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                }
                else { MessageBox.Show("Wrong ID or Password", "Nice Try", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Wrong ID or Password", "Nice Try", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
 
    }
}
