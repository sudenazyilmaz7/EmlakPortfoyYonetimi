using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakPortfoyYonetimi
{
    public partial class AnaPanelForm : Form
    {
        public AnaPanelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form 3'ü oluştur
            IlanEkleForm frmEkle = new IlanEkleForm();

            // Form 3'ü aç ve kullanıcı "Kaydet"e bastı mı kontrol et
            if (frmEkle.ShowDialog() == DialogResult.OK)
            {
                // Form 3 kapandıktan sonra içindeki değişkeni oku
                string gelenVeri = frmEkle.yeniIlanMetni;

                // Form 2'deki ListBox'a (lstIlanlar) bu veriyi ekle
                lstIlanlar.Items.Add(gelenVeri);

                MessageBox.Show("İlan başarıyla listeye eklendi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // StreamWriter kullanımını using ile sarmalayarak dosya kapanmasını garanti ediyoruz
            using (StreamWriter sw = new StreamWriter("ilanlar.txt"))
            {
                foreach (var item in lstIlanlar.Items)
                {
                    // ListBox'taki her bir satırı dosyaya yazar
                    sw.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Tüm ilanlar 'ilanlar.txt' dosyasına kaydedildi.");
        }

        private void AnaPanelForm_Load(object sender, EventArgs e)
        {
            lstIlanlar.Items.Add("Emlak Tipi | Satılık/Kiralık | Eklenme Tarihi | Takas Durumu | Açıklama");
            lstIlanlar.Items.Add("-------------------------------------------------------------");
            lstIlanlar.Items.Add("Örnek: Daire | Satılık | 01.01.2024 | Takasa Uygun | 3+1, deniz manzaralı");
            lstIlanlar.Items.Add("-------------------------------------------------------------");
            lstIlanlar.Items.Add("Yeni ilan eklemek için 'İlan Ekle' butonuna tıklayın.");
            lstIlanlar.Items.Add("-------------------------------------------------------------");


            // Eğer daha önce kaydedilmiş bir dosya varsa oku
            if (File.Exists("ilanlar.txt"))
            {
                string[] satirlar = File.ReadAllLines("ilanlar.txt");
                foreach (string satir in satirlar)
                {
                    lstIlanlar.Items.Add(satir);
                }
            }
        }
    }
}
