using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
//version 1.0
//copuright @ code for Haeytham Almalak
namespace Projct_2021
{
    public partial class Form1 : Form
    {
        bool? flag = null;
        int couter = 0;

        string[] ports = SerialPort.GetPortNames();
        string portSlected;


        public Form1()
        {
            InitializeComponent();
            lblTime.Enabled = false;
            ButnDisConct.Enabled = false;
            MaximizeBox = false;
            ControlBox = false;
            serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceve);
        }

        private void DataReceve(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                if (spl.ReadLine() == "" || spl.ReadLine() == " ")
                {
                    //Do nothing
                }
                if (spl.ReadLine() == "0")
                {
                    MessageBox.Show(spl.ReadLine());


                }
                if (spl.ReadLine() == "1")
                {
                    MessageBox.Show(spl.ReadLine());
                }
                if (spl.ReadLine() == "2")
                {
                    MessageBox.Show(spl.ReadLine());
                }
                else
                {
                    MessageBox.Show(spl.ReadLine() + "\n");
                }
            }
            catch (Exception)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            ButnConct.Enabled = true;
            ButnDisConct.Enabled = false;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                ButnConct.Enabled = true;
                ButnDisConct.Enabled = false;
                MessageBox.Show("DisConnected\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.SecurityBoxInfo.Clear();
            try
            {
                portSlected = cmboBxPortFind.SelectedItem.ToString();
            }
            catch (Exception)
            {
                SecurityBoxInfo.Text = ("Chose the Port First Please\n\n");
            }
            try
            {
                serialPort.PortName = portSlected;
                serialPort.BaudRate = 9600;
                serialPort.Open();

                if (!serialPort.IsOpen) return;

                ButnConct.Enabled = false;
                ButnDisConct.Enabled = true;

                MessageBox.Show("Connected\n");
            }
            catch (Exception)
            {
                SecurityBoxInfo.Text = ("No connection\n");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            SecurityBoxInfo.Text = "Disconnecting";

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                ButnConct.Enabled = true;
                ButnDisConct.Enabled = false;
                SecurityBoxInfo.Text = "";
                SecurityBoxInfo.Text = ("Disconnected\n");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("1");
                flag = true;
                if (flag == true)
                {
                    SecurityBoxInfo.Text = "You Have sent \"ON - 1\" to the station";
                }
            }
            catch (Exception ex)
            {
                SecurityBoxInfo.Text = (ex.Message + "\nYou Should Connect It First\n");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("0");

                flag = false;

                if (flag == false)
                {
                    SecurityBoxInfo.Text = "You Have sent \"RESET - 0 \" to the station";
                }
            }
            catch (Exception ex)
            {
                SecurityBoxInfo.Text = (ex.Message + "\nYou Should Connect It First\n");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void stringDisplay(string sData)
        {
            DateTime localDate = DateTime.Now;
            SecurityBoxInfo.AppendText(localDate + "   ");
            SecurityBoxInfo.AppendText(sData + "\n");
        }
        private void ClearButn_Click(object sender, EventArgs e)
        {
            this.SecurityBoxInfo.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            cmboBxPortFind.Items.Clear();
            foreach (string port in ports)
            {
                cmboBxPortFind.Items.Add(port);
                SecurityBoxInfo.Text = ("The following serial ports were found slect one please");
            }
        }
        public string textBox1 { get; set; }
        private void theProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button5_Click_2(object sender, EventArgs e)
        {

            try
            {
                serialPort.Write("2");
                lblTime.Enabled = true;
                couter = 10;
                TimeSnoozeCunt.Start();
                if (couter > 0)
                {
                    this.btbON.Enabled = false;
                    this.btnReset.Enabled = false;
                    this.btnSnozz.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                SecurityBoxInfo.Text = (ex.Message + "You Should Connect It First\n\n");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            couter = (Int32.Parse(lblTime.Text) - 1);
            if (couter < 0)
            {
                TimeSnoozeCunt.Stop();
                this.btbON.Enabled = true;
                this.btnReset.Enabled = true;
                this.btnSnozz.Enabled = true;
                lblTime.Enabled = false;
                couter = 0;
                lblTime.Text = "10";

            }
        }
        private void lblTime_Click(object sender, EventArgs e)
        {
            //lblTime.Text = "10";




        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void snoozeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help,How to use the application After the setup click on the icon to open the application.\n" +
                            "Use User ID    \"tpj\" & Use passrord   “123\" When you log succissfully you will see the control \n" +
                            "pannel of the application. At this moment you should make connection with the station by:\n" +
                            "1 - Click on “Find Connections\n" +
                            "2 - And click on “Ports Here\n" +
                            "3 - Select the pot you want for instance COM9\n" +
                            "Click on Connect you will see “No connection “ in Security Info or “Connected \n" +
                            "In this panel you will receive 1 from the Substation when you click on “ON” and 0 when you click on\n" +
                            "\"Reset\" and 2 when you click on “Snooze “that will be confirmation from the substation sent by\n" +
                            "Bluetooth means was successful. And the time snooze will account the time to “0” to make the application\n" +
                            "start immediately.");

        }

        private void theProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Trespasser-Trap version 1.0 \n" +
                            "   Created by Haeytham Almalak \n");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://192.168.1.68/");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" ERROR {ex}");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            try
            {
                System.Diagnostics.Process.Start("http://192.168.1.65/");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" ERROR {ex}");
            }
        }
    }
}
