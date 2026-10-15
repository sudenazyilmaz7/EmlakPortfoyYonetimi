using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EmlakPortfoyYonetimi
{
    public partial class IlanEkleForm : Form
    {
        public IlanEkleForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Bu değişken, Form 2'den okunabilecek
        public string yeniIlanMetni = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Verileri araçlardan topla
            string emlakTipi = cmbEmlakTipi.Text;
            string tarih = dtpEklenmeTarihi.Value.ToShortDateString();
            string aciklama = rtbAciklama.Text;
            string tur = rbSatilik.Checked ? "Satılık" : "Kiralık";
            string takas = chkTakas.Checked ? "Takasa Uygun" : "Takas Yok";

            // Hepsini tek bir satırda birleştir ve değişkene ata
            yeniIlanMetni = emlakTipi + " | " + tur + " | " + tarih + " | " + takas + " | " + aciklama;

            // Formu kapat
            this.DialogResult = DialogResult.OK; // Başarılı kapandığını bildirir
            this.Close();
        }
    }
}
