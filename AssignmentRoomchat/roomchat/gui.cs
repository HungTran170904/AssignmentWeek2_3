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
    public partial class gui : Form
    {
        private ChatRoom currentRoom;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private string senderName;
        
        private List<string> onlineUsers = new List<string>(); // Danh sách người dùng đang online
        public gui()
        {
            InitializeComponent();
        }
        public gui(ChatRoom room, string name)
        {
            InitializeComponent();
            currentRoom = room;
            senderName = name; // Save the sender's name
            ConnectToServer();


        }
        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", currentRoom.ServerIP);
                stream = client.GetStream();
                StartReceiving();
                string connect = $"JOIN|{senderName}";
                SendMessageToServer("",connect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến máy chủ: " + ex.Message);
            }
        }
        private void StartReceiving()
        {
            receiveThread = new Thread(() =>
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                try
                {
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        AddMessageToChat(message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhận tin nhắn từ máy chủ: " + ex.Message);
                }
            });

            receiveThread.Start();
        }



        private void btnsend_Click(object sender, EventArgs e)
        {
            string message = txtsend.Text;
            string fullMessage = $"{senderName}: {message}"; // Combining sender's name and message
           SendMessageToServer(senderName, message);
            AddMessageToChat(fullMessage); // Add the message to the chat box
            txtsend.Clear(); // Clear the send message box
        }

        private void SendMessageToServer(string name, string message)
        {
            try
            {
                string data = name + ":" + message;
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message);
            }
        }
        private StringBuilder messageBuilder = new StringBuilder();

        // Constructor và các phương thức khác

        private void AddMessageToChat(string message)
        {
            // Use Invoke to marshal the call to the UI thread
            if (txtChat.InvokeRequired)
            {
                txtChat.Invoke((MethodInvoker)delegate
                {
                    AddMessageToChat(message); // Call this method recursively on the UI thread
                });
            }
            else
            {
                // Append the message to the TextBox
                txtChat.AppendText(message + Environment.NewLine);

                // Scroll to the end to display the latest message
                txtChat.SelectionStart = txtChat.Text.Length;
                txtChat.ScrollToCaret();
            }
        }

        

        private void gui_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Khi người dùng đóng form, thông báo rời khỏi phòng chat
                string leaveMessage = $"LEAVE|{senderName}";
                SendMessageToServer(senderName, leaveMessage);
                client.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        private void HandleServerMessage(object sender, EventArgs e)
        {

        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbshowonline_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
