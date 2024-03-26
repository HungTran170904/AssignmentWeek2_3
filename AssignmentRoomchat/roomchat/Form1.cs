using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static roomchat.Form1;

namespace roomchat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static TcpListener server;
        static List<TcpClient> clients = new List<TcpClient>();
        private ServerConnection serverConnection;
        private string senderName;
        private List<int> room = new List<int>();
        private Thread listenThread;
        public class ChatRoom
        {
            public string RoomName { get; set; }
            public int ServerIP { get; set; }
            public int ServerPort { get; set; }

            public ChatRoom(string roomName, int serverIP)
            {
                RoomName = roomName;
                ServerIP = serverIP;

            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    break;
                }

                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received: " + message);

                BroadcastMessage(message, client);
            }

            clients.Remove(client);
            client.Dispose();
        }

        static void BroadcastMessage(string message, TcpClient excludeClient = null)
        {
            foreach (TcpClient client in clients)
            {
                if (client != excludeClient)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = Encoding.ASCII.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();
                }
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string roomname = txtname.Text;
            int serverPort = Int32.Parse(txtroomcode.Text);
            server = new TcpListener(IPAddress.Any, serverPort);
            listenThread = new Thread(ListenForClients);
            listenThread.Start();
           
            try
            {
                if (!room.Contains(serverPort))
                {

                    ChatRoom newRoom = new ChatRoom(roomname, serverPort);
                    Sever chatForm = new Sever(newRoom, txtname.Text); // Pass txtname.Text as the sender's name
                    TcpClient client = new TcpClient("127.0.0.1", serverPort); // Thay đổi địa chỉ IP nếu cần
                    NetworkStream stream = client.GetStream();

                    // Gửi yêu cầu tham gia phòng chat


                    // Mở giao diện phòng chat
                    ChatRoom NewRoom = new ChatRoom(roomname, serverPort);

                    Sever sever = new Sever(NewRoom, txtname.Text);
                    ;
                    gui ChatForm = new gui(NewRoom, txtname.Text); // Pass txtname.Text as the sender's name
                    ChatForm.Show();
                    room.Add(serverPort);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến phòng chat: " + ex.Message);
            }
            // this.Hide(); // Hide the current form instead of closing it
        }
        private void btnjoin_Click(object sender, EventArgs e)
        {
           
            string roomName = ""; 
            int serverip = Int32.Parse(txtroomcode.Text); // Cổng của phòng chat được chọn

            // Thực hiện kết nối đến phòng chat
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", serverip); // Thay đổi địa chỉ IP nếu cần
                NetworkStream stream = client.GetStream();

                // Gửi yêu cầu tham gia phòng chat
             

                // Mở giao diện phòng chat
                ChatRoom newRoom = new ChatRoom(roomName, serverip);
                gui chatForm = new gui(newRoom, txtname.Text); // Pass txtname.Text as the sender's name
                chatForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến phòng chat: " + ex.Message);
            }
        }
        private void ListenForClients()
        {
            try
            {

                while (true)
                {
                    server.Start();

                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);
                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn ROOMCODE khác");
            }
           

            
        }


       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtroomcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroomcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}