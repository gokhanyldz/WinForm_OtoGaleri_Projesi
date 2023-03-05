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
    public partial class Subeler : Form
    {
        public Subeler()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Sube.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tbl_Sube ekle=new Tbl_Sube();
            ekle.Sube_Adi = textBox2.Text;

            db.Tbl_Sube.Add(ekle);
            db.SaveChanges();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int ara = int.Parse(textBox1.Text);
            var update = db.Tbl_Sube.Find(ara);

            update.Sube_Adi = textBox2.Text;
            db.SaveChanges();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textBox1.Text);
            var delete = db.Tbl_Sube.Find(sil);

            db.Tbl_Sube.Remove(delete);

            delete.Sube_Adi= textBox2.Text;

            db.SaveChanges();
        }
    }
}
