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
        static string IPConnect = "192.168.43.90";
        static int PORT_NUMBER = 9999;
        static int length;
        public Form_main()
        {
            InitializeComponent();
            Thread Time = new Thread(() =>
            {
                while (true)
                {
                    string time = DateTime.Now.ToLongTimeString();
                    string date = DateTime.Now.ToLongDateString();
                    textTime.Text = time;
                    textDate.Text = date;
                }
            });
            Time.IsBackground = true;
            Time.Start();
            CheckForIllegalCrossThreadCalls = false;
            user = Form_login.user;
            length = user.Length;
            // listMsg.Items.Add("User : " + user);

            
            AddMessage("User : " + user);
            listOnline.Items.Add("🍚 : "+user);
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
                textConnect.Text = "👉 "+ user + " 👈";
                //byte[] name = Encoding.ASCII.GetBytes(user);

                client.Send(stringtoByte(user));
            }
            catch
            {
                MessageBox.Show("unable to connect please try later!", "🍓🍔🍕🍖🍚", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddMessage("Error Connect");
                textConnect.Text = "Error Connect";

                Application.Exit();
                return;             
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        byte[] stringtoByte(string s)
        {
            return Encoding.UTF8.GetBytes(s);
        }
        string bytetoString(byte[] x)
        {
            return Encoding.UTF8.GetString(x);
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
                AddMessage(textMsg.Text);
                textMsg.Clear();
            }

        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    string data2 = null;
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)bytetoString(data);
                    
                    if (message[0] == '#')
                    {
                                     
                        listOnline.Items.Add(message);
                       // AddMessage(data2);
                    }
                    else if (message[0] != '#')
                    {
                        AddMessage(message);
                    }
                    
                       
                }
            }
            catch
            {
                //Close();
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
            if (s != textMsg.Text)
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
               // AddMessage(textMsg.Text);
                
            }
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                client.Send(stringtoByte("exit"));
                Application.Exit();
            }
                

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
            
        }
        
        private void btClear_Click(object sender, EventArgs e)
        {
            textStatus.Clear();   
        }

        private void Form_main_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btSend.PerformClick();
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
