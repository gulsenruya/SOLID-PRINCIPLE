using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrediKartBuilder_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KrediKartiBuilder krediKarti;
        private void BtnKartOlustur_Click(object sender, EventArgs e)
        {
            switch (cmBoxKartipi.Text)
            {
                case "Visa":
                    krediKarti = new VisaConcreteBuilder();           
                    break;
                case "Master":
                    krediKarti = new VisaConcreteBuilder();
                    break;
                case "American Express":
                    krediKarti = new VisaConcreteBuilder();
                    break;
            }
            KartKullan kartKullan = new KartKullan();
            kartKullan.KartiKullan(krediKarti,tbxBankaAdi.Text,cmBoxKartipi.Text,nupKartLimit.Value,radBtnVar.Checked);
            ListView();

        }
        public void ListView()
        {
            ListViewItem listView = new ListViewItem();
            listView.Text = krediKarti.Kart.BankaAdi;
            listView.SubItems.Add(krediKarti.Kart.KartTipi);
            listView.SubItems.Add(krediKarti.Kart.Limit.ToString());
            listView.SubItems.Add(krediKarti.Kart.Taksit.ToString());
            listView1.Items.Add(listView);
        }
    }
}
