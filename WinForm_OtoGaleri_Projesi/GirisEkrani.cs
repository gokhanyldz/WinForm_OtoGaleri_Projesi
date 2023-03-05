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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db=new DbFirst_OtoGaleriEntities();
        



        private void btn_giris_Click(object sender, EventArgs e)
        {
            var gkn = db.Kayit.FirstOrDefault(x => x.Personel_KullaniciAd == txt_kullaniciadi.Text);

            if (gkn!=null)
            {
                if (gkn.Personel_Sifre==txt_sifre.Text)
                {
                    MenuEkrani mn = new MenuEkrani();
                    mn.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları eksiksiz giriniz.");
            }

        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            KullaniciKayit kk= new KullaniciKayit();
            kk.Show();
           



        }
    }
}
