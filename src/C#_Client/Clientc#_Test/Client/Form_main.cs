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
        static string IPConnect;
        static int PORT_NUMBER;
        
        static NetworkStream networkStream = null;
        
        public Form_main()
        {
            InitializeComponent();
            //    CheckForIllegalCrossThreadCalls = false;
            user = Form_login.user;
            IPConnect = Form_login.ip;
            PORT_NUMBER = int.Parse(Form_login.port);
            listMsg.Items.Add("User : " + user);
            listMsg.Items.Add("IP : " + IPConnect);
            listMsg.Items.Add("Port : " + PORT_NUMBER);
            Connect();
            
           // client.Send(Serialize(user));

        }
        IPEndPoint IP;
        // TcpClient client;
        Socket sclient = null;
        public void Connect()
        {
             IP = new IPEndPoint(IPAddress.Parse(IPConnect), PORT_NUMBER);
             sclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
             try
             {
                 sclient.Connect(IP);
                 AddMessage(sclient.RemoteEndPoint.ToString()+"Connected !");
             }
             catch
             {
                 MessageBox.Show("Error Connect");
                 return;
             }
            /* Thread listen = new Thread(Receive);
             listen.IsBackground = true;
             listen.Start();*/
            /*  try
              {
                  client = new TcpClient(IPConnect, PORT_NUMBER);
                 // client.Connect(IPConnect, PORT_NUMBER);
                  AddMessage("Connected !");
                  x`
              }
              catch
              {
                  AddMessage("False");
              }*/
            networkStream = new NetworkStream(sclient);
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.WriteLine(user);
            streamWriter.Flush();
            StreamReader streamReader = new StreamReader(networkStream);
            
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();


        }
        
        void Close()
        {
            sclient.Close();
        }
        void Send()
        {
            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);
            if (textMsg.Text != string.Empty)
            {
                //    client.Send(Serialize(textMsg.Text));
                streamWriter.WriteLine(textMsg.Text);
                streamWriter.Flush();
            }

        }
        
        void Receive()
        {
            /*  try
              {
                  while (true)
                  {
                      byte[] data = new byte[1024 * 5000];
                      client.Receive(data);
                      string message = (string)Deseriliaze(data);
                      AddMessage(message);
                  }
              }
              catch
              {
                  Close();
              }*/

            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);
            
            try
            {
                while (true)
                {

                    string message = streamReader.ReadLine();                  
                    AddMessage(message);
                }
            }
            catch
            {

            }
        }
          void AddMessage(string s)
          {
              //    listMsg.Items.Add(new ListViewItem() { Text = s });

              if (s == textMsg.Text)
              {
                  string time = DateTime.Now.ToString("hh:mm:ss");
                  listMsg.Items.Add("| " + time + " | " + "[ " + "Me" + " ] : " + s);
              }
              if (s != textMsg.Text)
              {
                  listMsg.Items.Add(s);

              }

              listMsg.SelectedIndex = listMsg.Items.Count - 1;
              listMsg.SelectedIndex = -1;
              textMsg.Clear();

        }
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy 
            return stream.ToArray();
        }
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btSend.PerformClick();
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
            if (textMsg.Text != string.Empty)
            {
                Send();
                AddMessage(textMsg.Text);
            }
           
        }
    }
}
