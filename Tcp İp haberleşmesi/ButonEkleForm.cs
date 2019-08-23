using Microsoft.VisualC.StlClr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_İp_haberleşmesi
{


    public partial class ButonEkleForm : Form
    {

        //public OnOffButton OnOffBtn;
        public OnOffButton tıklananButon;
        //CtrlBtnAndOnOffBtn eklenenButon;
        public TcpClient tcp;
        Button clickedButton;

        List<OnOffButton> InstancesOfOnOffButons = new List<OnOffButton>();

        List<Button> CreatedButtons = new List<Button>();


        int top = 10;

        int left = 5;
        int sayac = 0;
       

        string butonAdi;
       

        public ButonEkleForm()
        {
            InitializeComponent();
            
        }

        private void ButonEkleForm_Load(object sender, EventArgs e)
        {

            tcp = new TcpClient();

        }

        private void ButonEkle_Click(object sender, EventArgs e)
        {

            butonOlustur();

        }

        private void ButonEklemeKapatma_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void eklenenButon_Click(object sender, EventArgs e)
        {

        }

        internal void butonOlustur()
        {

            Label eklenenButonAd = new Label();
            eklenenButonAd.Location = new Point(5, 10);
            eklenenButonAd.Name = yeniBtnAd.Text;
            eklenenButonAd.Text = yeniBtnAd.Text;
            eklenenButonAd.Height = 20;
            eklenenButonAd.Width = 170;
            eklenenButonAd.BackColor = Color.White;
            eklenenButonAd.ForeColor = Color.Black;
            eklenenButonAd.Visible = true;
            eklenenButonAd.TextAlign = ContentAlignment.MiddleCenter;
            eklenenButonAd.Enabled = true;
            eklenenButonAd.AutoSize = false;
            eklenenButonAd.Font = new Font("Arial", 12, FontStyle.Bold);

            OnOffButton CtrlBtnAndOnOffBtn = new OnOffButton();

            CtrlBtnAndOnOffBtn.Name = yeniBtnAd.Text;
            MessageBox.Show("eklenen butun adı: " + CtrlBtnAndOnOffBtn.Name);
            CtrlBtnAndOnOffBtn.BackColor = Color.Gray;
            CtrlBtnAndOnOffBtn.Location = new Point(60, 40);
            CtrlBtnAndOnOffBtn.Text = yeniBtnAd.Text;
            CtrlBtnAndOnOffBtn.ForeColor = Color.Black;
            CtrlBtnAndOnOffBtn.Width = 60;
            CtrlBtnAndOnOffBtn.Height = 60;
            CtrlBtnAndOnOffBtn.Visible = true;



            CtrlBtnAndOnOffBtn.textAdi = yeniBtnAd.Text;
            CtrlBtnAndOnOffBtn.gelenDataON = yeniBtnOnAlınanVeri.Text + "\r\n";
            CtrlBtnAndOnOffBtn.gidenDataON = yeniBtnOnGonderilenVeri.Text;
            CtrlBtnAndOnOffBtn.gelenDataOFF = yeniBtnOffAlınanVeri.Text + "\r\n";
            CtrlBtnAndOnOffBtn.gidenDataOFF = yeniBtnOffGonderilenVeri.Text;
            CtrlBtnAndOnOffBtn.gonderilenData = yeniBtnOnGonderilenVeri.Text;

            CreatedButtons.Add(CtrlBtnAndOnOffBtn);
            CtrlBtnAndOnOffBtn.Click += new EventHandler(eklenenButon_Click);

            

            butonAdi = yeniBtnAd.Text;


            GroupBox yeniButton = new GroupBox();
            yeniButton.Size = new Size(180, 110);
            yeniButton.Location = new Point(left, top);
            yeniButton.Visible = true;

            yeniButton.Controls.Add(CtrlBtnAndOnOffBtn);
            yeniButton.Controls.Add(eklenenButonAd);
            

            IntPtr m = Application.OpenForms["HaberlesmeForm"].Handle;

            yeniButton.Parent = HaberlesmeForm.FromHandle(m).Controls.Find("ButonBox", true).FirstOrDefault() as GroupBox;

            left += 185;

            if (left + yeniButton.Width >= yeniButton.Parent.Width)
            {

                left = 5;
                top += 130;

            }

            foreach (Control eleman in this.Controls)
            {

                if (eleman is TextBox)
                {
                    TextBox textBox = (TextBox)eleman;
                    textBox.Clear();

                }
            }

            sayac++;
 
        }

    }
}

