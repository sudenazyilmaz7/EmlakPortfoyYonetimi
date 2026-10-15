using System;
using System.Linq;
using System.Windows.Forms;

namespace EmlakPortfoyYonetimi
{
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // 1. Şifre Kriter Kontrolü
            if (!SifreUygunMu(sifre))
            {
                MessageBox.Show("Şifre en az 8 karakter olmalı; büyük harf, küçük harf, rakam ve özel karakter içermelidir!", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kullanıcı zaten var mı?
            if (Form1.Kullanicilar.Any(u => u.KullaniciAdi == ad))
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Hata");
                return;
            }

            // 3. Kayıt Oluşturma
            Random rnd = new Random();
            string kod = rnd.Next(1000, 9999).ToString();

            Form1.Kullanicilar.Add(new Form1.KullaniciBilgi
            {
                KullaniciAdi = ad,
                Sifre = sifre,
                GuvenlikKodu = kod
            });

            MessageBox.Show($"Kayıt Başarılı!\n\nGÜVENLİK KODUNUZ: {kod}\n\nŞifrenizi unutursanız bu kod gerekecektir.", "Bilgi");
            this.Close(); // Kayıttan sonra formu kapat
        }

        private bool SifreUygunMu(string s)
        {
            return s.Length >= 8 && s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit) && s.Any(ch => !char.IsLetterOrDigit(ch));
        }

    }
}
