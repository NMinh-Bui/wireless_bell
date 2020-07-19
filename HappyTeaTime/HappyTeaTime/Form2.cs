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
    public partial class Form2 : Form
    {

        string dataIN;
        int i = 0, A1 = 0, A2 = 0, A3 = 0, A4 = 0, A5 = 0, A6 = 0, 
            A7 = 0, A8 = 0, A9 = 0, A10 = 0, A11 = 0, A12 = 0;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Form1.SPortdata.Portname;
            serialPort1.BaudRate = Convert.ToInt32(Form1.SPortdata.Baudrate);
            serialPort1.DataBits = Convert.ToInt32(Form1.SPortdata.DataBits);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Form1.SPortdata.StopBits);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Form1.SPortdata.ParityBit);
            
            serialPort1.Open();

            CboxBan1.Enabled = false;
            CboxBan2.Enabled = false;
            CboxBan3.Enabled = false;
            CboxBan4.Enabled = false;
            CboxBan5.Enabled = false;
            CboxBan6.Enabled = false;
            CboxBan7.Enabled = false;
            CboxBan8.Enabled = false;
            CboxBan9.Enabled = false;
            CboxBan10.Enabled = false;
            CboxBan11.Enabled = false;
            CboxBan12.Enabled = false;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(CheckTable));           
        }

        private void CheckTable(object sender, EventArgs e)
        {
            if (dataIN == "1")
            {
                if (CboxBan1.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A1 = i;
                    lblBan1.Text = Convert.ToString(A1);
                }
                CboxBan1.Checked = true;

            }
            else if (dataIN == "2")
            {
                if (CboxBan2.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A2 = i;
                    lblBan2.Text = Convert.ToString(A2);
                }
                CboxBan2.Checked = true;
            }
            else if (dataIN == "3")
            {
                if (CboxBan3.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A3 = i;
                    lblBan3.Text = Convert.ToString(A3);
                }
                CboxBan3.Checked = true;
            }
            else if (dataIN == "4")
            {
                if (CboxBan4.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A4 = i;
                    lblBan4.Text = Convert.ToString(A4);
                }
                CboxBan4.Checked = true;
            }
            else if (dataIN == "5")
            {
                if (CboxBan5.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A5 = i;
                    lblBan5.Text = Convert.ToString(A5);
                }
                CboxBan5.Checked = true;
            }
            else if (dataIN == "6")
            {
                if (CboxBan6.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A6 = i;
                    lblBan6.Text = Convert.ToString(A6);
                }
                CboxBan6.Checked = true;
            }
            else if (dataIN == "7")
            {
                if (CboxBan7.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A7 = i;
                    lblBan7.Text = Convert.ToString(A7);
                }
                CboxBan7.Checked = true;
            }
            else if (dataIN == "8")
            {
                if (CboxBan8.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A8 = i;
                    lblBan8.Text = Convert.ToString(A8);
                }
                CboxBan8.Checked = true;
            }
            else if (dataIN == "9")
            {
                if (CboxBan9.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A9 = i;
                    lblBan9.Text = Convert.ToString(A9);
                }
                CboxBan9.Checked = true;
            }
            else if (dataIN == ":")
            {
                if (CboxBan10.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A10 = i;
                    lblBan10.Text = Convert.ToString(A10);
                }
                CboxBan10.Checked = true;
            }
            else if (dataIN == ";")
            {
                if (CboxBan11.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A11 = i;
                    lblBan11.Text = Convert.ToString(A11);
                }
                CboxBan11.Checked = true;
            }
            else if (dataIN == "<")
            {
                if (CboxBan12.CheckState != CheckState.Checked)
                {
                    i = i + 1;
                    A12 = i;
                    lblBan12.Text = Convert.ToString(A12);
                }
                CboxBan12.Checked = true;
            }

            if (i == 1)
            {
                if (lblBan1.Text == "1") { lblServe.Text = "01"; }
                if (lblBan2.Text == "1") { lblServe.Text = "02"; }
                if (lblBan3.Text == "1") { lblServe.Text = "03"; }
                if (lblBan4.Text == "1") { lblServe.Text = "04"; }
                if (lblBan5.Text == "1") { lblServe.Text = "05"; }
                if (lblBan6.Text == "1") { lblServe.Text = "06"; }
                if (lblBan7.Text == "1") { lblServe.Text = "07"; }
                if (lblBan8.Text == "1") { lblServe.Text = "08"; }
                if (lblBan9.Text == "1") { lblServe.Text = "09"; }
                if (lblBan10.Text == "1") { lblServe.Text = "10"; }
                if (lblBan11.Text == "1") { lblServe.Text = "11"; }
                if (lblBan12.Text == "1") { lblServe.Text = "12"; }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (A1 == 1) { CboxBan1.Checked = false; }
            if (A2 == 1) { CboxBan2.Checked = false; }
            if (A3 == 1) { CboxBan3.Checked = false; }
            if (A4 == 1) { CboxBan4.Checked = false; }
            if (A5 == 1) { CboxBan5.Checked = false; }
            if (A6 == 1) { CboxBan6.Checked = false; }
            if (A7 == 1) { CboxBan7.Checked = false; }
            if (A8 == 1) { CboxBan8.Checked = false; }
            if (A9 == 1) { CboxBan9.Checked = false; }
            if (A10 == 1) { CboxBan10.Checked = false; }
            if (A11 == 1) { CboxBan11.Checked = false; }
            if (A12 == 1) { CboxBan12.Checked = false; }

            if (A1 == 0) { A1 = A1 + 1; }
            if (A2 == 0) { A2 = A2 + 1; }
            if (A3 == 0) { A3 = A3 + 1; }
            if (A4 == 0) { A4 = A4 + 1; }
            if (A5 == 0) { A5 = A5 + 1; }
            if (A6 == 0) { A6 = A6 + 1; }
            if (A7 == 0) { A7 = A7 + 1; }
            if (A8 == 0) { A8 = A8 + 1; }
            if (A9 == 0) { A9 = A9 + 1; }
            if (A10 == 0) { A10 = A10 + 1; }
            if (A11 == 0) { A11 = A11 + 1; }
            if (A12 == 0) { A12 = A12 + 1; }

            A1 = A1 - 1;
            A2 = A2 - 1;
            A3 = A3 - 1;
            A4 = A4 - 1;
            A5 = A5 - 1;
            A6 = A6 - 1;
            A7 = A7 - 1;
            A8 = A8 - 1;
            A9 = A9 - 1;
            A10 = A10 - 1;
            A11 = A11 - 1;
            A12 = A12 - 1;
            lblBan1.Text = Convert.ToString(A1);
            lblBan2.Text = Convert.ToString(A2);
            lblBan3.Text = Convert.ToString(A3);
            lblBan4.Text = Convert.ToString(A4);
            lblBan5.Text = Convert.ToString(A5);
            lblBan6.Text = Convert.ToString(A6);
            lblBan7.Text = Convert.ToString(A7);
            lblBan8.Text = Convert.ToString(A8);
            lblBan9.Text = Convert.ToString(A9);
            lblBan10.Text = Convert.ToString(A10);
            lblBan11.Text = Convert.ToString(A11);
            lblBan12.Text = Convert.ToString(A12);


            if (i != 0) { i = i - 1; }

            if (i == 0) { lblServe.Text = "00"; }
            if (lblBan1.Text == "1") { lblServe.Text = "01"; }
            if (lblBan2.Text == "1") { lblServe.Text = "02"; }
            if (lblBan3.Text == "1") { lblServe.Text = "03"; }
            if (lblBan4.Text == "1") { lblServe.Text = "04"; }
            if (lblBan5.Text == "1") { lblServe.Text = "05"; }
            if (lblBan6.Text == "1") { lblServe.Text = "06"; }
            if (lblBan7.Text == "1") { lblServe.Text = "07"; }
            if (lblBan8.Text == "1") { lblServe.Text = "08"; }
            if (lblBan9.Text == "1") { lblServe.Text = "09"; }
            if (lblBan10.Text == "1") { lblServe.Text = "10"; }
            if (lblBan11.Text == "1") { lblServe.Text = "11"; }
            if (lblBan12.Text == "1") { lblServe.Text = "12"; }
        }

    }
}
