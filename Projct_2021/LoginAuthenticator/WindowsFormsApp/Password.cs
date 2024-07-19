using LibLoginAuthenticator;
using Projct_2021;
using System;
using System.Windows.Forms;
//version 1.0
//copuright @ code for Haeytham Almalak
namespace WindowsFormsApp
{

    public partial class Password : Form
    {
        LoginAuthenticator log = new LoginAuthenticator();
        public Password()
        {
            InitializeComponent();
            MaximizeBox = false;
            ControlBox = false;
            txtPassBx.Text = "";
            txtPassBx.Text = "";
            txtUsrBx.Text = "";
            txtUsrBx.MaxLength = 9;
            txtPassBx.MaxLength = 9;
            txtPassBx.PasswordChar = '*';

        }

        private void txtUsrBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            log.userName = txtUsrBx.Text;
            log.password = txtPassBx.Text;

            bool? checkPoint = log.Authenticate();

            if (checkPoint == null)
            {
                MessageBox.Show("you should enter the fill info please");

            }
            if (checkPoint == false)
            {
                MessageBox.Show("Try agamin");

            }
            if (checkPoint == true)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
                MessageBox.Show("Welcome Back !");


            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtUsrBx.Clear();
            txtPassBx.Clear();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtUsrBx.Clear();
            txtPassBx.Clear();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsrBx.Clear();
            txtPassBx.Clear();
        }

        private void warningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutTheProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Trespasser-Trap  \n" +
                            "   Created by Haeytham Almalak \n");
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do Not Use this Application without Permission", " Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // icon.ToString("Do Not Use this Application without Permission");
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
