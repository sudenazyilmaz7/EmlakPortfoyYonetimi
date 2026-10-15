using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmlakPortfoyYonetimi
{
    public partial class Form1 : Form
    {
        public class KullaniciBilgi
        {
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }
            public string GuvenlikKodu { get; set; }
        }

        // Static olduğu için program kapanana kadar veriler RAM'de kalır
        public static List<KullaniciBilgi> Kullanicilar = new List<KullaniciBilgi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKullanici.Text.Trim(); // Trim boşlukları siler
            string sifre = txtSifre.Text;

            // Listede bu kullanıcı var mı bakıyoruz
            var kullanici = Kullanicilar.FirstOrDefault(u => u.KullaniciAdi == ad && u.Sifre == sifre);

            if (kullanici != null)
            {
                MessageBox.Show("Giriş Başarılı!", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // AnaPanelForm'u aç
                AnaPanelForm anaPanel = new AnaPanelForm();
                anaPanel.Show();
                this.Hide();
            }
            else
            {
                // Kullanıcı bulunamadıysa uyarı ver
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!\n\nEğer kayıt olmadıysanız lütfen önce 'Kayıt Ol' butonuna basın.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlForm frm = new KayitOlForm();
            frm.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifreSifirlaForm frm = new SifreSifirlaForm();
            frm.ShowDialog();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false; // Bazı Windows sürümlerinde çakışma yapmaması için
            txtSifre.PasswordChar = '*';
        }

    }
}