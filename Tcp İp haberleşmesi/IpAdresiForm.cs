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
    public partial class IpAdresiForm : Form
    {


        public IpAdresiForm()
        {
            InitializeComponent();
        }

       

        private void IpAdresiForm_Load(object sender, EventArgs e)
        {

        }

       

        private void Baglan_Click(object sender, EventArgs e)
        {   

            this.Hide();

            IntPtr m = Application.OpenForms["HaberlesmeForm"].Handle;

            Button serverebaglan = HaberlesmeForm.FromHandle(m).Controls.Find("ServerBaglanBtn", true).FirstOrDefault() as Button;

            Label lbBaglantiBilgisi = HaberlesmeForm.FromHandle(m).Controls.Find("lbBaglantiBilgisi", true).FirstOrDefault() as Label;

            OnOffButton.IpAdress= IpAdresiTextBox.Text;
            OnOffButton.PortNo= Convert.ToInt32(PortNoTextBox.Text);

            OnOffButton.ServeraBaglan(serverebaglan,  lbBaglantiBilgisi);
            
        } 
    }
}
