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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Personel.ToList();

            using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            {
                comboBox1.DataSource = db.Tbl_Sube.ToList();
                comboBox1.ValueMember = "Sube_ID";
                comboBox1.DisplayMember = "Sube_Adi";
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tbl_Personel ekle = new Tbl_Personel();
            ekle.Personel_Ad_Soyad = txt_adsoyad.Text;
            ekle.Personel_Yas = txt_yas.Text;
            ekle.Personel_TcNo = maskedTextBox1.Text;
            ekle.Personel_Mail = txt_mail.Text;
            ekle.Personel_Telefon = maskedTextBox2.Text;
            ekle.Sube_ID = int.Parse(comboBox1.SelectedValue.ToString());
            db.Tbl_Personel.Add(ekle);
            db.SaveChanges();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int guncelle = int.Parse(textBox1.Text);
            var update = db.Tbl_Personel.Find(guncelle);
            update.Personel_Ad_Soyad = txt_adsoyad.Text;
            update.Personel_Yas = txt_yas.Text;
            update.Personel_TcNo = maskedTextBox1.Text;
            update.Personel_Mail = txt_mail.Text;
            update.Personel_Telefon = maskedTextBox2.Text;
            update.Sube_ID = int.Parse(comboBox1.SelectedValue.ToString());

            
            db.SaveChanges();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textBox1.Text);
            var delete = db.Tbl_Personel.Find(sil);

            db.Tbl_Personel.Remove(delete);

            delete.Personel_Ad_Soyad = txt_adsoyad.Text;
            delete.Personel_Yas = txt_yas.Text;
            delete.Personel_TcNo = maskedTextBox1.Text;
            delete.Personel_Mail = txt_mail.Text;
            delete.Sube_ID = int.Parse(comboBox1.SelectedValue.ToString());

            db.SaveChanges();
        }
    }
}
