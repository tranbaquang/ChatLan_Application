using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form_login : Form
    {
        public static string user;
        public static string ip;
        public static string port;
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            user = textName.Text;
            if (user == string.Empty || user == "")
            {
                MessageBox.Show("Please Enter Your Name", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Text = string.Empty;
                
            }
            else if (user != string.Empty)
            {
                /* ip = textIPC.Text;
                port = textPort.Text;*/
                Form_main f2 = new Form_main();
                this.Hide();
                f2.ShowDialog();
                //  this.Show();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btAccept.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
