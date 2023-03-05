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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();
        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Arac.ToList();

            //using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            //{
            //    comboBox1.DataSource = db.Tbl_Sube.ToList();
            //    comboBox1.ValueMember = "Sube_ID";
            //    comboBox1.DisplayMember = "Sube_Adi";
            //}
            using (DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities())
            {
                comboBox2.DataSource = db.Tbl_Arac_Durumu.ToList();
                comboBox2.ValueMember = "Arac_Durumu_ID";
                comboBox2.DisplayMember = "Arac_Durumu_Adi";
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tbl_Arac ekle= new Tbl_Arac();
            ekle.Arac_Fiyat=txt_aracfiyat.Text;
            ekle.Arac_Adet = txt_aracadet.Text;
            ekle.Arac_Marka = txt_aracmarka.Text;
            ekle.Arac_Model = txt_aracmodel.Text;
            ekle.Arac_Yil=txt_aracyil.Text;
            ekle.Sanziman=txt_sanziman.Text;
            ekle.Motor_Hacmi = Convert.ToDecimal(txt_motorhacmi.Text);
            ekle.Arac_Yakit = txt_aracyakit.Text;
            ekle.Arac_Paket=txt_aracpaket.Text;
            ekle.Arac_Renk = txt_aracrenk.Text;
            ekle.Arac_Km = txt_arackm.Text;
            ekle.Sube_ID = int.Parse(textBox2.Text);
            ekle.Arac_Durumu_ID = int.Parse(comboBox2.Text);
            
            db.Tbl_Arac.Add(ekle);
            db.SaveChanges();


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int guncelle = int.Parse(textBox1.Text);
            var update = db.Tbl_Arac.Find(guncelle);
            update.Arac_Adet = txt_aracadet.Text;
            update.Arac_Marka = txt_aracmarka.Text;
            update.Arac_Model = txt_aracmodel.Text;
            update.Arac_Yil = txt_aracyil.Text;
            update.Sanziman = txt_sanziman.Text;
            update.Motor_Hacmi = Convert.ToDecimal(txt_motorhacmi.Text);
            update.Arac_Yakit = txt_aracyakit.Text;
            update.Arac_Paket = txt_aracpaket.Text;
            update.Arac_Renk = txt_aracrenk.Text;
            update.Arac_Km = txt_arackm.Text;
            update.Sube_ID = int.Parse(textBox2.Text);
            update.Arac_Durumu_ID = int.Parse(comboBox2.Text);

            update.Arac_Fiyat = txt_aracfiyat.Text;

            db.SaveChanges();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textBox1.Text);
            var delete = db.Tbl_Arac.Find(sil);

            db.Tbl_Arac.Remove(delete);

            delete.Arac_Adet = txt_aracadet.Text;
            delete.Arac_Marka = txt_aracmarka.Text;
            delete.Arac_Model = txt_aracmodel.Text;
            delete.Arac_Yil = txt_aracyil.Text;
            delete.Sanziman = txt_sanziman.Text;
            delete.Motor_Hacmi = Convert.ToDecimal(txt_motorhacmi.Text);
            delete.Arac_Yakit = txt_aracyakit.Text;
            delete.Arac_Paket = txt_aracpaket.Text;
            delete.Arac_Renk = txt_aracrenk.Text;
            delete.Arac_Km = txt_arackm.Text;
            delete.Sube_ID = int.Parse(textBox2.Text);
            delete.Arac_Durumu_ID = int.Parse(comboBox2.Text);

            delete.Arac_Fiyat = txt_aracfiyat.Text;

            db.SaveChanges();




        }
    }
}
