using System.Net.Sockets;

namespace Server
{
    internal class ReadServer
    {
        private TcpListener server;
        public ReadServer(TcpListener server)
        {
            this.server = server;
        }

        public void Run()
        {

        }
    }
}
