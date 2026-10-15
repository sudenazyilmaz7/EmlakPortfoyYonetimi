namespace EmlakPortfoyYonetimi
{
    partial class IlanEkleForm
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
            this.cmbEmlakTipi = new System.Windows.Forms.ComboBox();
            this.rbSatilik = new System.Windows.Forms.RadioButton();
            this.dtpEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkTakas = new System.Windows.Forms.CheckBox();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rbKiralik = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbEmlakTipi
            // 
            this.cmbEmlakTipi.FormattingEnabled = true;
            this.cmbEmlakTipi.Location = new System.Drawing.Point(12, 12);
            this.cmbEmlakTipi.Name = "cmbEmlakTipi";
            this.cmbEmlakTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbEmlakTipi.TabIndex = 0;
            this.cmbEmlakTipi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbSatilik
            // 
            this.rbSatilik.AutoSize = true;
            this.rbSatilik.Location = new System.Drawing.Point(192, 16);
            this.rbSatilik.Name = "rbSatilik";
            this.rbSatilik.Size = new System.Drawing.Size(53, 17);
            this.rbSatilik.TabIndex = 1;
            this.rbSatilik.TabStop = true;
            this.rbSatilik.Text = "Satılık";
            this.rbSatilik.UseVisualStyleBackColor = true;
            // 
            // dtpEklenmeTarihi
            // 
            this.dtpEklenmeTarihi.Location = new System.Drawing.Point(588, 9);
            this.dtpEklenmeTarihi.Name = "dtpEklenmeTarihi";
            this.dtpEklenmeTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpEklenmeTarihi.TabIndex = 2;
            // 
            // chkTakas
            // 
            this.chkTakas.AutoSize = true;
            this.chkTakas.Location = new System.Drawing.Point(13, 76);
            this.chkTakas.Name = "chkTakas";
            this.chkTakas.Size = new System.Drawing.Size(79, 17);
            this.chkTakas.TabIndex = 3;
            this.chkTakas.Text = "Takaslı mı?";
            this.chkTakas.UseVisualStyleBackColor = true;
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(224, 74);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(283, 69);
            this.rtbAciklama.TabIndex = 4;
            this.rtbAciklama.Text = "İlan Detayları:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(224, 280);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "İlanı Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rbKiralik
            // 
            this.rbKiralik.AutoSize = true;
            this.rbKiralik.Location = new System.Drawing.Point(192, 40);
            this.rbKiralik.Name = "rbKiralik";
            this.rbKiralik.Size = new System.Drawing.Size(53, 17);
            this.rbKiralik.TabIndex = 7;
            this.rbKiralik.TabStop = true;
            this.rbKiralik.Text = "Kiralık";
            this.rbKiralik.UseVisualStyleBackColor = true;
            // 
            // IlanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbKiralik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.chkTakas);
            this.Controls.Add(this.dtpEklenmeTarihi);
            this.Controls.Add(this.rbSatilik);
            this.Controls.Add(this.cmbEmlakTipi);
            this.Name = "IlanEkleForm";
            this.Text = "IlanEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmlakTipi;
        private System.Windows.Forms.RadioButton rbSatilik;
        private System.Windows.Forms.DateTimePicker dtpEklenmeTarihi;
        private System.Windows.Forms.CheckBox chkTakas;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbKiralik;
    }
}