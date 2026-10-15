namespace EmlakPortfoyYonetimi
{
    partial class SifreSifirlaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adını Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "4 Haneli Güvenlik Kodunu Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre Giriniz:";
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Location = new System.Drawing.Point(279, 329);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(133, 23);
            this.btnSifreGuncelle.TabIndex = 3;
            this.btnSifreGuncelle.Text = "Şifreyi Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(250, 112);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(250, 199);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 20);
            this.txtKod.TabIndex = 5;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(250, 276);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre.TabIndex = 6;
            // 
            // SifreSifirlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnSifreGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SifreSifirlaForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtYeniSifre;
    }
}