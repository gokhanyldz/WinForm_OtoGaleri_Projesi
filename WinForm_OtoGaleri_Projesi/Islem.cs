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
    public partial class Islem : Form
    {
        public Islem()
        {
            InitializeComponent();
        }

        DbFirst_OtoGaleriEntities db=new DbFirst_OtoGaleriEntities();

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_İslemler.ToList();

            using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            {
                comboBox1.DataSource = db.Tbl_Musteri.ToList();
                comboBox1.ValueMember = "Musteri_ID";
                comboBox1.DisplayMember = "Musteri_AdSoyad";
            }
            using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            {
                comboBox2.DataSource = db.Tbl_Arac.ToList();
                comboBox2.ValueMember = "Arac_ID";
                comboBox2.DisplayMember = "Arac_Model";
            }
            using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            {
                comboBox3.DataSource = db.Tbl_Personel.ToList();
                comboBox3.ValueMember = "Personel_ID";
                comboBox3.DisplayMember = "Personel_Ad_Soyad";
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tbl_İslemler ekle = new Tbl_İslemler();
            ekle.Islem_Tarihi = maskedTextBox1.Text;
            ekle.Islem_Fiyati = decimal.Parse(txt_fiyat.Text);
            
            ekle.Musteri_ID = int.Parse(comboBox1.SelectedValue.ToString());
            ekle.Arac_ID = int.Parse(comboBox2.SelectedValue.ToString());
            ekle.Personel_ID = int.Parse(comboBox3.SelectedValue.ToString());


            db.Tbl_İslemler.Add(ekle);
            db.SaveChanges();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int guncelle = int.Parse(textBox1.Text);
            var update = db.Tbl_İslemler.Find(guncelle);
            update.Islem_Tarihi = maskedTextBox1.Text;
            update.Islem_Fiyati = decimal.Parse(txt_fiyat.Text);
            update.Musteri_ID = int.Parse(comboBox1.SelectedValue.ToString());
            update.Arac_ID = int.Parse(comboBox2.SelectedValue.ToString());
            update.Personel_ID = int.Parse(comboBox3.SelectedValue.ToString());


            

            db.SaveChanges();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textBox1.Text);
            var delete = db.Tbl_İslemler.Find(sil);

            db.Tbl_İslemler.Remove(delete);

            delete.Islem_Tarihi = maskedTextBox1.Text;
            delete.Islem_Fiyati = decimal.Parse(txt_fiyat.Text);
            delete.Musteri_ID = int.Parse(comboBox1.SelectedValue.ToString());
            delete.Arac_ID = int.Parse(comboBox2.SelectedValue.ToString());
            delete.Personel_ID = int.Parse(comboBox3.SelectedValue.ToString());

            db.SaveChanges();
        }
    }
}
