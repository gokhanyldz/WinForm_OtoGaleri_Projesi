using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_OtoGaleri_Projesi
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();

        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Personel_KullaniciAd = txt_kullaniciadi_kayitol.Text;
            kyt.Personel_AdSoyad = txt_adsoyad.Text;
            kyt.Personel_TcNo = maskedTextBox1.Text;
            kyt.Personel_Sifre = txt_sifre_kayitol.Text;

            db.Kayit.Add(kyt);
            db.SaveChanges();
            MessageBox.Show("Kaydınız yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_girisvarsa_Click(object sender, EventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
        }
    }
}
