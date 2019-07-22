using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
namespace Client
{
    public partial class Form_main : Form
    {
           
        static string user;
        static string IPConnect = "127.0.0.1";
        static int PORT_NUMBER = 7777;
        static int length;
        public Form_main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            user = Form_login.user;
            length = user.Length;
            // listMsg.Items.Add("User : " + user);

            
            AddMessage("User : " + user);

            Connect();
            

        }
        IPEndPoint IP;
        Socket client;
       
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse(IPConnect), PORT_NUMBER);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);      
            try
            {
                client.Connect(IP);
                textStatus.AppendText("\n");
                AddMessage(client.RemoteEndPoint.ToString()+" Connected !");
                //byte[] name = Encoding.ASCII.GetBytes(user);

                client.Send(stringtoByte(user));
            }
            catch
            {
                MessageBox.Show("unable to connect please try later!", "🍓🍔🍕🍖🍚", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddMessage("Error Connect");
                Application.Exit();
                return;             
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        byte[] stringtoByte(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }
        string bytetoString(byte[] x)
        {
            return Encoding.ASCII.GetString(x);
        }
        void Close()
        {
            client.Close();
        }
        void Send()
        {
            if (textMsg.Text != string.Empty || textMsg.Text != "")
            {
                client.Send(stringtoByte(textMsg.Text));
            }

        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)bytetoString(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }
        void AddMessage(string s)
        {
            //    listMsg.Items.Add(new ListViewItem() { Text = s });

            if (s == textMsg.Text)
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                textStatus.AppendText("\n");
                textStatus.AppendText("| " + time + " | " + "[ " + "Me" + " ] : " + s );

            }
            else if (s != textMsg.Text)
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                textStatus.AppendText("\n");
                textStatus.AppendText("| "+time+" | :"+s);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (textMsg.Text != string.Empty || textMsg.Text != "" )
            {
                Send();
                AddMessage(textMsg.Text);
                textMsg.Clear();
            }
            textMsg.Text = null;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             Application.Exit();
           
        }

        private void textMsg_TextChanged(object sender, EventArgs e)
        {
           /// textMsg.MaxLength = 20;
        }

        private void textMsg_Enter(object sender, EventArgs e)
        {
           
        }

        private void textStatus_TextChanged(object sender, EventArgs e)
        {
            textStatus.ScrollBars = ScrollBars.Both;
        }

        private void textMsg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSend.PerformClick();
            }
        }
    }
}
