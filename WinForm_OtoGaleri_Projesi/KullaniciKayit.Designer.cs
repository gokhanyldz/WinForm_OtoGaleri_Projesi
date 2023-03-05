namespace WinForm_OtoGaleri_Projesi
{
    partial class KullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKayit));
            this.btn_girisvarsa = new System.Windows.Forms.Button();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.txt_sifre_kayitol = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi_kayitol = new System.Windows.Forms.TextBox();
            this.linklbl_geridon = new System.Windows.Forms.LinkLabel();
            this.lbl_sifre_kayitol = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi_kayitol = new System.Windows.Forms.Label();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_girisvarsa
            // 
            this.btn_girisvarsa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_girisvarsa.Location = new System.Drawing.Point(360, 354);
            this.btn_girisvarsa.Name = "btn_girisvarsa";
            this.btn_girisvarsa.Size = new System.Drawing.Size(290, 35);
            this.btn_girisvarsa.TabIndex = 17;
            this.btn_girisvarsa.Text = "HESABINIZ VARSA GİRİŞ YAPINIZ";
            this.btn_girisvarsa.UseVisualStyleBackColor = false;
            this.btn_girisvarsa.Click += new System.EventHandler(this.btn_girisvarsa_Click);
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_kayıtol.Location = new System.Drawing.Point(425, 236);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(148, 23);
            this.btn_kayıtol.TabIndex = 16;
            this.btn_kayıtol.Text = "KAYIT OL";
            this.btn_kayıtol.UseVisualStyleBackColor = false;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // txt_sifre_kayitol
            // 
            this.txt_sifre_kayitol.Location = new System.Drawing.Point(425, 156);
            this.txt_sifre_kayitol.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre_kayitol.Name = "txt_sifre_kayitol";
            this.txt_sifre_kayitol.Size = new System.Drawing.Size(148, 20);
            this.txt_sifre_kayitol.TabIndex = 14;
            // 
            // txt_kullaniciadi_kayitol
            // 
            this.txt_kullaniciadi_kayitol.Location = new System.Drawing.Point(425, 120);
            this.txt_kullaniciadi_kayitol.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullaniciadi_kayitol.Name = "txt_kullaniciadi_kayitol";
            this.txt_kullaniciadi_kayitol.Size = new System.Drawing.Size(148, 20);
            this.txt_kullaniciadi_kayitol.TabIndex = 13;
            // 
            // linklbl_geridon
            // 
            this.linklbl_geridon.AutoSize = true;
            this.linklbl_geridon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.linklbl_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_geridon.LinkColor = System.Drawing.Color.Black;
            this.linklbl_geridon.Location = new System.Drawing.Point(25, 9);
            this.linklbl_geridon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbl_geridon.Name = "linklbl_geridon";
            this.linklbl_geridon.Size = new System.Drawing.Size(129, 24);
            this.linklbl_geridon.TabIndex = 12;
            this.linklbl_geridon.TabStop = true;
            this.linklbl_geridon.Text = "<--GERİDÖN";
            // 
            // lbl_sifre_kayitol
            // 
            this.lbl_sifre_kayitol.AutoSize = true;
            this.lbl_sifre_kayitol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_sifre_kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre_kayitol.Location = new System.Drawing.Point(342, 156);
            this.lbl_sifre_kayitol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sifre_kayitol.Name = "lbl_sifre_kayitol";
            this.lbl_sifre_kayitol.Size = new System.Drawing.Size(51, 16);
            this.lbl_sifre_kayitol.TabIndex = 10;
            this.lbl_sifre_kayitol.Text = "ŞİFRE";
            // 
            // lbl_kullaniciadi_kayitol
            // 
            this.lbl_kullaniciadi_kayitol.AutoSize = true;
            this.lbl_kullaniciadi_kayitol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_kullaniciadi_kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullaniciadi_kayitol.Location = new System.Drawing.Point(285, 120);
            this.lbl_kullaniciadi_kayitol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kullaniciadi_kayitol.Name = "lbl_kullaniciadi_kayitol";
            this.lbl_kullaniciadi_kayitol.Size = new System.Drawing.Size(111, 16);
            this.lbl_kullaniciadi_kayitol.TabIndex = 9;
            this.lbl_kullaniciadi_kayitol.Text = "KULLANICI ADI";
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(425, 81);
            this.txt_adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(148, 20);
            this.txt_adsoyad.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "AD-SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "T.C NO";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(425, 44);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txt_adsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_girisvarsa);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.txt_sifre_kayitol);
            this.Controls.Add(this.txt_kullaniciadi_kayitol);
            this.Controls.Add(this.linklbl_geridon);
            this.Controls.Add(this.lbl_sifre_kayitol);
            this.Controls.Add(this.lbl_kullaniciadi_kayitol);
            this.Name = "KullaniciKayit";
            this.Text = "KullaniciKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_girisvarsa;
        private System.Windows.Forms.Button btn_kayıtol;
        private System.Windows.Forms.TextBox txt_sifre_kayitol;
        private System.Windows.Forms.TextBox txt_kullaniciadi_kayitol;
        private System.Windows.Forms.LinkLabel linklbl_geridon;
        private System.Windows.Forms.Label lbl_sifre_kayitol;
        private System.Windows.Forms.Label lbl_kullaniciadi_kayitol;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}