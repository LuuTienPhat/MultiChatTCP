using DevExpress.XtraEditors;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MultiChatTCP
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private static IPAddress host = IPAddress.Parse("127.0.0.1");
        private static int port = 7777;
        private static TcpClient client;
        private static int BUFFER_SIZE = 999999;
        //private static ThisClient thisClient = ThisClient.Intance;

        public MainForm()
        {
            try
            {
                InitializeComponent();
                this.Name = "Client";
                //client = new TcpClient();
                //client.Connect(host, port);
                //NetworkStream ns = client.GetStream();
                //string message = "hello";
                //ns.Write(Encoding.UTF8.GetBytes(message), 0, Encoding.UTF8.GetBytes(message).Length);

                //byte[] receiveBytes = new byte[BUFFER_SIZE];
                //int receiveBytesLength = ns.Read(receiveBytes, 0, BUFFER_SIZE);
                //string receiveMessage = Encoding.UTF8.GetString(receiveBytes, 0, receiveBytesLength);

                //XtraMessageBox.Show(receiveMessage, this.Name);

                //client.Close();
                //Environment.Exit(Environment.ExitCode);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), this.Name);
            }

        }

        private void Read(TcpClient client)
        {
            while (true)
            {
                try
                {
                    NetworkStream stream = client.GetStream();

                    byte[] receiveBytes = new byte[BUFFER_SIZE];
                    int receiveBytesLength = stream.Read(receiveBytes, 0, BUFFER_SIZE);
                    string receiveMessage = Encoding.UTF8.GetString(receiveBytes, 0, receiveBytesLength);
                    //XtraMessageBox.Show(receiveMessage, this.Name);

                    chatView.AppendText(receiveMessage + "\n");
                    //treeList1.Nodes.Add(receiveMessage);

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, this.Name);
                }
            }
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {

            if (txtAddress.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Please enter host adress", this.Name);
                return;
            }

            if (txtPort.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Please enter host port", this.Name);
                return;
            }

            host = IPAddress.Parse(txtAddress.Text);
            port = int.Parse(txtPort.Text);

            try
            {
                //thisClient.Client.Connect(host, port);
                client = new TcpClient();
                client.Connect(host, port);

                Thread t = new Thread(() => Read(client));
                t.Start();

                //client.Close();


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), this.Name);
            }

        }

        public void sendData(TcpClient client)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                byte[] sendBytes = Encoding.UTF8.GetBytes(txtMessage.Text);
                stream.Write(sendBytes, 0, sendBytes.Length);

                chatView.AppendText(txtMessage.Text + "\n");
                //treeList1.Nodes.Add(txtMessage.Text);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), this.Name);
            }
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            Environment.Exit(Environment.ExitCode);
        }

        private void chatView_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
