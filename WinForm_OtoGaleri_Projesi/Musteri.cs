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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tbl_Musteri ekle = new Tbl_Musteri();
            ekle.Musteri_AdSoyad = txt_musteriadsoyad.Text;
            ekle.Musteri_TcNo = txt_musteritcno.Text;
            ekle.Musteri_Mail = txt_musterimail.Text;
            ekle.Musteri_Telefon = maskedTextBox2.Text;
            
            

            db.Tbl_Musteri.Add(ekle);
            db.SaveChanges();

        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textBox1.Text);
            var delete = db.Tbl_Musteri.Find(sil);

            db.Tbl_Musteri.Remove(delete);

            delete.Musteri_AdSoyad = txt_musteriadsoyad.Text;
            delete.Musteri_TcNo = txt_musteritcno.Text;
            delete.Musteri_Mail = txt_musterimail.Text;
            delete.Musteri_Telefon = maskedTextBox2.Text;

            db.SaveChanges();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            int guncelle = int.Parse(textBox1.Text);
            var update = db.Tbl_Musteri.Find(guncelle);


            update.Musteri_AdSoyad = txt_musteriadsoyad.Text;
            update.Musteri_TcNo = txt_musteritcno.Text;
            update.Musteri_Mail = txt_musterimail.Text;
            update.Musteri_Telefon = maskedTextBox2.Text;

            db.SaveChanges();
        }
    }
}
