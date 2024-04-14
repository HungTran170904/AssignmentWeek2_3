using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static roomchat.Form1;
using static System.Windows.Forms.LinkLabel;

namespace roomchat
{
    public partial class Sever : Form
    {
        private ChatRoom currentRoom;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        private string senderName;
        private List<TcpClient> clients;

        public Sever(ChatRoom room, string name)
        {
            InitializeComponent();
            currentRoom = room;
            senderName = name; // Save the sender's name
            ConnectToServer();


        }


        public Sever()
        {
            InitializeComponent();
        }
        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", currentRoom.ServerIP);
                stream = client.GetStream();
                StartReceiving();
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


                {
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        AddMessageToChat(message);
                    }
                }

            });

            receiveThread.Start();
        }

        private void AddMessageToChat(string message)
        {
            // Use Invoke to marshal the call to the UI thread
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    AddMessageToChat(message); // Call this method recursively on the UI thread
                });
            }
            else
            {
                // Append the message to the TextBox
                richTextBox1.AppendText(message + Environment.NewLine);

                // Scroll to the end to display the latest message
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //  richTextBox1.AppendText($"JOIN|{senderName}");
        }
        public void xuly()
        {
            string input = richTextBox1.Text; // Chuỗi đầu vào

            // Tách các dòng thành các chuỗi riêng biệt
            string[] lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Duyệt qua từng dòng
            foreach (string line in lines)
            {
                // Tìm vị trí của dấu |
                int pipeIndex = line.IndexOf('|');
                if (pipeIndex != -1 && pipeIndex < line.Length - 1)
                {
                    // Lấy phần sau của chuỗi sau dấu |
                    string secondPart = line.Substring(pipeIndex + 1);
                    Console.WriteLine(secondPart.Trim()); // In ra phần sau đã được làm sạch
                }
            }
        }
    }
}