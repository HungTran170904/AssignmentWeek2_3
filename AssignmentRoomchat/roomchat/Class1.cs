using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace roomchat
{
    public class ServerConnection
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        public event EventHandler<string> MessageReceived;

        public bool IsConnected { get; private set; }

        public ServerConnection(string serverIP, int serverPort)
        {
            client = new TcpClient();

            try
            {
                client.Connect(serverIP, serverPort);
                stream = client.GetStream();
                IsConnected = true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi kết nối
                IsConnected = false;
                Console.WriteLine("Không thể kết nối đến máy chủ: " + ex.Message);
            }
        }

        public void StartReceiving()
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
                        OnMessageReceived(message);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi nhận tin nhắn từ máy chủ
                    Console.WriteLine("Lỗi khi nhận tin nhắn từ máy chủ: " + ex.Message);
                }
            });

            receiveThread.Start();
        }

        public void SendMessage(string message)
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi gửi tin nhắn
                Console.WriteLine("Lỗi khi gửi tin nhắn: " + ex.Message);
            }
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }

        public void Close()
        {
            if (client != null)
            {
                client.Close();
            }

            if (stream != null)
            {
                stream.Close();
            }
        }
    }
}
