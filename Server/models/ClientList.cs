using System.Collections.Generic;
using System.Net.Sockets;

namespace Server
{
    public sealed class ClientList
    {
        private List<TcpClient> clients = new List<TcpClient>();
        public List<TcpClient> Clients
        {
            get { return clients; }
            //set { clients = value; }
        }

        private static readonly object padlock = new object();
        private static ClientList instance = null;
        private ClientList() { }
        public static ClientList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ClientList();
                    }
                    return instance;
                }
            }
        }
    }
}
