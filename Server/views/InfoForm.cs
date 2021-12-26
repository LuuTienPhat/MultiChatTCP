namespace Server
{
    public partial class InfoForm : DevExpress.XtraEditors.XtraForm
    {
        public InfoForm()
        {
            InitializeComponent();
            foreach (var client in ClientList.Instance.Clients)
            {
                listBoxControl1.Items.Add(client.Client.RemoteEndPoint);
            }
        }
    }
}