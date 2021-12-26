using DevExpress.XtraEditors;
using System;
using System.Net.Sockets;

namespace MultiChatTCP
{
    internal class Read
    {
        private TcpClient client;

        public Read(TcpClient client)
        {
            this.client = client;
        }

        public void run()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                while (true)
                {

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
