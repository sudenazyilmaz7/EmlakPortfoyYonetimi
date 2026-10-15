using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmlakPortfoyYonetimi
{
    public partial class SifreSifirlaForm : Form
    {
        public SifreSifirlaForm()
        {
            InitializeComponent();
        }


        // Şifre kriterlerini kontrol eden metod (Büyük, küçük, sayı, özel karakter)
        private bool SifreKriterleriniDogrula(string sifre)
        {
            bool uzunlukTamam = sifre.Length >= 8;
            bool buyukHarf = sifre.Any(char.IsUpper);
            bool kucukHarf = sifre.Any(char.IsLower);
            bool rakam = sifre.Any(char.IsDigit);
            bool ozelKarakter = sifre.Any(ch => !char.IsLetterOrDigit(ch));

            if (!(uzunlukTamam && buyukHarf && kucukHarf && rakam && ozelKarakter))
            {
                MessageBox.Show("Yeni şifreniz kriterlere uygun değil!\n\n" +
                                "- En az 8 karakter olmalı\n" +
                                "- Büyük harf, küçük harf, rakam ve özel karakter içermelidir.",
                                "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SifreSifirlaForm_Load(object sender, EventArgs e)
        {
            txtYeniSifre.PasswordChar = '*';
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {

            string ad = txtKullaniciAdi.Text;
            string kod = txtKod.Text;
            string yeniSifre = txtYeniSifre.Text;

            // 1. Liste tarama (Hocanın istediği en basit döngü yöntemi)
            Form1.KullaniciBilgi bulunanKullanici = null;

            foreach (Form1.KullaniciBilgi k in Form1.Kullanicilar)
            {
                if (k.KullaniciAdi == ad && k.GuvenlikKodu == kod)
                {
                    bulunanKullanici = k;
                    break;
                }
            }

            // 2. Kullanıcı bulunduysa şifre kriterlerini kontrol et
            if (bulunanKullanici != null)
            {
                // Senin eklemek istediğin karmaşık şifre kontrol metodunu çağırıyoruz
                if (SifreKriterleriniDogrula(yeniSifre))
                {
                    bulunanKullanici.Sifre = yeniSifre; // Şifreyi güncelle
                    MessageBox.Show("Şifre başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya güvenlik kodu hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}