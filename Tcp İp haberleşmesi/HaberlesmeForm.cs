using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_İp_haberleşmesi
{
    public partial class HaberlesmeForm : Form
    {

        public ButonEkleForm butoneklemeFormu = new ButonEkleForm();

        IpAdresiForm IpAdresiForm = new IpAdresiForm();

        public HaberlesmeForm()
        {
            InitializeComponent();
        }

        private void HaberlesmeForm_Load(object sender, EventArgs e)
        {
          
        }

        private void SeverBaglanBtn_Click(object sender, EventArgs e)
        {
            OnOffButton.ServeraBaglan(ServerBaglanBtn, lbBaglantiBilgisi);
        }

        private void ButonEkle_Click(object sender, EventArgs e)
        {
            butoneklemeFormu.Show();
        }

        private void ButonSil_Click(object sender, EventArgs e)
        {
           
        }

        private void KirmiziLed_Click(object sender, EventArgs e)
        {
            //kirmiziLedOnOffBtn.butonaTıklandıgında(KirmiziLed, ServerBaglanBtn, GelenVeriBox);
        }

         

        private void IpAdresiDuzeltBtn_Click(object sender, EventArgs e)
        {
            IpAdresiForm.Show();


        }

        private void ButonBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
