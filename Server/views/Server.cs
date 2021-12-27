using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : DevExpress.XtraEditors.XtraForm
    {
        private static IPAddress host = IPAddress.Parse("127.0.0.1");
        private static int port = 7777;
        private static TcpListener server;
        private const int BUFFER_SIZE = 999999999;
        private static Thread serverTheard;
        private static List<Thread> threads = new List<Thread>();
        // Thread signal.  
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public Server()
        {
            InitializeComponent();
            ServerStopped();
        }

        public void Read(TcpClient client, int threadIndex)
        {
            while (true)
            {
                try
                {
                    NetworkStream stream = client.GetStream();

                    byte[] receiveBytes = new byte[BUFFER_SIZE];
                    int receiveBytesLength = stream.Read(receiveBytes, 0, BUFFER_SIZE);
                    string receiveMessage = Encoding.UTF8.GetString(receiveBytes, 0, receiveBytesLength);

                    foreach (var c in ClientList.Instance.Clients)
                    {
                        if (c != client)
                        {
                            NetworkStream ns = c.GetStream();
                            byte[] sendBytes = Encoding.UTF8.GetBytes(receiveMessage);
                            ns.Write(sendBytes, 0, sendBytes.Length);
                        }
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), this.Name);
                    foreach (var c in ClientList.Instance.Clients)
                    {
                        if (c == client) ClientList.Instance.Clients.Remove(c);
                    }
                    UpdateListView();
                    threads[threadIndex].Join();
                    threads.Remove(threads[threadIndex]);
                }
            }
        }

        private void UpdateListView()
        {
            OnlineList.Items.Clear();
            foreach (var c in ClientList.Instance.Clients)
            {
                OnlineList.Items.Add(c.Client.RemoteEndPoint);
            }
        }

        private void StartServer()
        {
            while (true)
            {
                try
                {
                    // 1. accept
                    TcpClient client = server.AcceptTcpClient();


                    //Thread t = new Thread(() => Read(client, threads.Count));
                    //threads.Add(t);
                    //t.Start();



                    this.Invoke((MethodInvoker)delegate
                    {
                        OnlineList.Items.Add(client.Client.RemoteEndPoint);
                        ClientList.Instance.Clients.Add(client);
                    });



                    //NetworkStream stream = client.GetStream();

                    //// 2. receive
                    //byte[] receiveBytes = new byte[BUFFER_SIZE];
                    //int length = stream.Read(receiveBytes, 0, BUFFER_SIZE);

                    //string message = Encoding.UTF8.GetString(receiveBytes);

                    // 3. handle
                    //if (length != 0)
                    //{
                    //    string receivedData = Encoding.ASCII.GetString(receivedDataByte, 0, length);

                    //    string[] requestSplit = receivedData.Split('*');

                    //    if (requestSplit[0].Equals("download"))
                    //    {
                    //        FileInfo fi = new FileInfo(requestSplit[requestSplit.Length - 1]);
                    //        FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);

                    //        //4. send
                    //        byte[] fileLength = Encoding.UTF8.GetBytes(fs.Length.ToString());
                    //        stream.Write(fileLength, 0, fileLength.Length);
                    //        stream.Flush();

                    //        progressBar.EditValue = 0;
                    //        sendFile(stream, fs, fi);
                    //        lbDetail.Caption = "Listening on " + server.LocalEndpoint;
                    //    }
                    //    else
                    //    {
                    //        List<string> filters = new List<string>();

                    //        for (int i = 1; i < requestSplit.Length - 1; i++)
                    //        {
                    //            filters.Add(requestSplit[i]);
                    //        }

                    //        DirectoryView directoryCollection = LoadDirectory(requestSplit[requestSplit.Length - 1], filters);
                    //        byte[] sendData = ObjectToByteArray(directoryCollection);

                    //        // 4. send
                    //        stream.Write(sendData, 0, sendData.Length);
                    //    }
                    //}

                    // 5. close
                    //stream.Close();
                    //client.Close();
                    //GC.Collect();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), this.Name);
                }
            }

        }

        public void ServerStopped()
        {
            LbStatus.Text = "Not Activated";
            LbDetail.Caption = "Server stopped!";
            TxtAddress.Enabled = TxtPort.Enabled = BtnStart.Enabled = true;
            BtnRestart.Enabled = BtnStop.Enabled = clientPanel.Enabled = false;

            //progressBar.EditValue = 0;
            clientPanel.Enabled = false;

            //this.Invoke((MethodInvoker)delegate
            //{
            //    OnlineList.Items.Clear();
            //});
        }



        public void ServerStarted()
        {
            LbStatus.Text = "Activated";
            LbDetail.Caption = "Listening on " + server.LocalEndpoint;
            TxtAddress.Enabled = TxtPort.Enabled = BtnStart.Enabled = false;
            BtnRestart.Enabled = BtnStop.Enabled = clientPanel.Enabled = true;

            //progressBar.EditValue = 0;
            clientPanel.Enabled = true;
        }

        private static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        #region Buttons

        public void Connect()
        {
            // Establish the local endpoint for the socket.  
            // The DNS name of the computer  
            // running the listener is "host.contoso.com".  
            //IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress ipAddress = ipHostInfo.AddressList[0];
            //IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.  
            //Socket listener = new Socket(ipAddress.AddressFamily,
            //    SocketType.Stream, ProtocolType.Tcp);
            server = new TcpListener(host, port);

            // Bind the socket to the local endpoint and listen for incoming connections.  
            try
            {
                //listener.Bind(localEndPoint);
                //listener.Listen(100);

                //server.Server.Listen(100);
                server.Start();
                //ServerStarted();

                while (true)
                {
                    // Set the event to nonsignaled state.  
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.  
                    //Console.WriteLine("Waiting for a connection...");
                    server.BeginAcceptTcpClient(
                        new AsyncCallback(AcceptCallback),
                        server);

                    // Wait until a connection is made before continuing.  
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                ServerStopped();
            }

            //Console.WriteLine("\nPress ENTER to continue...");
            //Console.Read();
        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            //Socket listener = (Socket)ar.AsyncState;
            //Socket handler = listener.EndAccept(ar);

            server = (TcpListener)ar.AsyncState;
            TcpClient client = server.EndAcceptTcpClient(ar);

            ClientList.Instance.Clients.Add(client);

            // Create the state object.  
            StateObject state = new StateObject();
            state.client = client;
            client.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject)ar.AsyncState;
            TcpClient handler = state.client;

            try
            {
                string content = string.Empty;

                // Read data from the client socket.
                int bytesRead = handler.Client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There  might be more data, so store the data received so far.  
                    state.sb.Append(Encoding.ASCII.GetString(
                        state.buffer, 0, bytesRead));

                    // Check for end-of-file tag. If it is not there, read
                    // more data.  
                    content = state.sb.ToString();
                    //XtraMessageBox.Show(content, "Server");
                    if (content.Length > 0)
                    {
                        // All the data has been read from the
                        // client. Display it on the console.  
                        //Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        //    content.Length, content);

                        // Echo the data back to the client.
                        foreach (var c in ClientList.Instance.Clients)
                        {
                            if (c != handler)
                            {
                                Send(c, content);
                            }
                        }

                        handler.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                    }
                    else
                    {
                        // Not all data received. Get more.  
                        handler.Client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                    }
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.ToString(), "Server");
                ClientList.Instance.Clients.Remove(handler);
                handler.Close();
            }

        }

        private static void Send(TcpClient handler, string data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.Client.BeginSend(byteData, 0, byteData.Length, 0,
        new AsyncCallback(SendCallback), handler);

        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                //Socket handler = (Socket)ar.AsyncState;

                TcpClient handler = (TcpClient)ar.AsyncState;

                // Complete sending the data to the remote device.  
                //int bytesSent = handler.EndSend(ar);
                handler.Client.EndSend(ar);
                //Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                //handler.Client.Shutdown(SocketShutdown.Both);
                //handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private bool CheckInput()
        {
            try
            {
                if (TxtAddress.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Please enter server address");
                    return false;
                }
                else
                {
                    host = IPAddress.Parse(TxtAddress.Text.Trim());
                }


                if (TxtPort.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show("Please enter server port");
                    return false;
                }
                else
                {
                    port = int.Parse(TxtPort.Text.Trim());
                }
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(ex.ToString(), this.Name);
                return false;
            }
            return true;
        }

        //btnStart
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!CheckInput()) return;
            else
            {
                host = IPAddress.Parse(TxtAddress.Text);
                port = int.Parse(TxtPort.Text);

                //try
                //{
                //    server = new TcpListener(host, port);
                //    server.Server.Listen(100);


                //    // 1. listen
                //    server.Start();
                //    ServerStarted();

                //}
                //catch (Exception ex)
                //{
                //    XtraMessageBox.Show(ex.ToString(), this.Name);
                //    //ServerStopped();
                //}

                //serverTheard = new Thread(StartServer);
                //serverTheard.Start();

                serverTheard = new Thread(new ThreadStart(Connect));
                serverTheard.Start();
            }
        }

        //btnExit
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        //btnStop
        [Obsolete]
        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverTheard.IsAlive)
                {
                    serverTheard.Suspend();
                }
                server.Stop();
                ServerStopped();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //btnRestart
        [Obsolete]
        private void btnRestart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (serverTheard.IsAlive)
                {
                    serverTheard.Suspend();
                }
                server.Stop();
                ServerStopped();


                server = new TcpListener(host, port);
                // 1. listen
                server.Start();
                ServerStarted();

                serverTheard = new Thread(StartServer);
                serverTheard.Start();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Name);
                ServerStopped();
            }

        }

        #endregion

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new InfoForm().Show();
        }
    }

    public class StateObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        //public Socket workSocket = null;
        public TcpClient client = null;
    }
}
