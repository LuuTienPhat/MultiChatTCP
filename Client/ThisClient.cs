using System.Net;
using System.Net.Sockets;

namespace MultiChatTCP
{
    internal class ThisClient
    {
        private ThisClient() { }

        private IPAddress host;
        public IPAddress Host { get; set; }

        private int port;
        public int Port { get; set; }

        private TcpClient client = new TcpClient();
        public TcpClient Client
        {
            get { return client; }
            //set { client = value; }
        }

        public void Connect(IPAddress host, int port)
        {
            this.host = host;
            this.port = port;
            client.Connect(host, port);
        }

        private static readonly object padlock = new object();
        private static ThisClient instance = null;


        public static ThisClient Intance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new ThisClient();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
