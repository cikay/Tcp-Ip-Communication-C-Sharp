using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace Tcp_İp_haberleşmesi
{
    public partial class OnOffButton : Button
    {
        public OnOffButton()
        {
            InitializeComponent();
        }

        

        public string textAdi { get; set; }
        public string gidenDataOFF { get; set; }
        public string gidenDataON { get; set; }
        public string gelenDataON { get; set; }
        public string gelenDataOFF { get; set; }
        public string gonderilenData { get; set; }

        public string butonName { get; set; }

        public int sayac { get; set; } = 0;

        internal static int top { get; set; } = 10;
        internal static int left { get; set; } = 5;

        public static TcpClient tcp = new TcpClient();
        Ping ping = new Ping();
        PingOptions pOptions = new PingOptions();
        PingReply pingCevap;
        NetworkStream okuYaz;
        string GELENDATA;



        public int satirNo { get; set; }
        public int sutunNo { get; set; }

        public static string IpAdress { get; set; } = "";

        public static int PortNo { get; set; }


        public void OnOff(string gelenData)
        {

            if (string.Compare(gelenData, gelenDataON, true) == 0)
            {
                this.BackColor = Color.DeepSkyBlue;

                this.Text = "ON";
                gonderilenData = gidenDataOFF;
            }
            else if (string.Compare(gelenData, gelenDataOFF, true) == 0)
            {
                this.BackColor = Color.Gray;
                this.Text = "OFF";
                gonderilenData = gidenDataON;

            }

          
        }


        public void Off(Button btn, Label lb)
        {
            lb.Text = textAdi;
            btn.BackColor = Color.Gray;
            btn.Text = "OFF";
        }

        public void butonaTıklandıgında(Button ServereBaglan, ListBox listBox1)
        {
            try
            {
                okuYaz = tcp.GetStream();
                PingAt();

                 if (pingCevap.Status == IPStatus.Success)
                 {

                     //MessageBox.Show("gonderilen data: "+gonderilenData);
                     byte[] mesaj_dizi = Encoding.ASCII.GetBytes(gonderilenData);
                     byte[] gelen = new byte[tcp.ReceiveBufferSize];
                     OkuYaz(listBox1, okuYaz, gelen, mesaj_dizi);
                     OnOff(GELENDATA);

                 }
                 else MessageBox.Show("Sunucuya bağlı değilsiniz!");
            }
            catch
            {
                ServereBaglan.BackColor = Color.Blue;
                ServereBaglan.ForeColor = Color.White;
                MessageBox.Show("Gönderilen data boş veya hatalı!");
            }
        }

        public static void ServeraBaglan(Button btn, Label lbBaglantiBilgisi)
        {

            if (String.Compare(IpAdress, "") != 0)
            {

                try
                {
                    tcp = new TcpClient();
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.DimGray;
                    tcp.Connect(IpAdress, PortNo);
                    lbBaglantiBilgisi.Text = "Servera bağlısınız!";
                }
                catch
                {
                    btn.BackColor = Color.Blue;
                    btn.ForeColor = Color.White;
                    lbBaglantiBilgisi.Text = "Servera bağlı değilsiniz!";

                }

            }
            else
            {
                MessageBox.Show("Ip adresi ya da Port numarası girmediniz!!!");

            }

        }

        public void PingAt()
        {
            pOptions.DontFragment = true;
            byte[] myByte = new byte[32];
            pingCevap = ping.Send("192.168.2.85", 80, myByte, pOptions);
        }

        public void OkuYaz(ListBox listBox1, NetworkStream okuYaz, byte[] gelen, byte[] mesaj_dizi)
        {
            if (okuYaz.CanWrite)
            {
                okuYaz.Write(mesaj_dizi, 0, mesaj_dizi.Length);
                string gonderilenVeri = Encoding.ASCII.GetString(mesaj_dizi);

            }
            else
            {
                MessageBox.Show("veri gönderilemedi!!");
                tcp.Close();
                return;
            }

            if (okuYaz.CanRead)
            {
                okuYaz.Read(gelen, 0, (int)tcp.ReceiveBufferSize);
                GELENDATA = Encoding.ASCII.GetString(gelen);
                listBox1.Items.Add(GELENDATA);
            }
            else
            {
                MessageBox.Show("veri alınmadı!!");
                tcp.Close();
                return;
            }
        }


        protected override void OnClick(EventArgs e)
        {

            MessageBox.Show("gelen data:", gelenDataOFF);

            IntPtr m = Application.OpenForms["HaberlesmeForm"].Handle;

            Button serverebaglan = HaberlesmeForm.FromHandle(m).Controls.Find("ServerBaglanBtn", true).FirstOrDefault() as Button;
            ListBox gelenDataList = HaberlesmeForm.FromHandle(m).Controls.Find("GelenVeriBox", true).FirstOrDefault() as ListBox;

            butonaTıklandıgında(serverebaglan, gelenDataList);
            MessageBox.Show("eklenen buton ad:", this.Name);
            base.OnClick(e);

        }

    }
}


