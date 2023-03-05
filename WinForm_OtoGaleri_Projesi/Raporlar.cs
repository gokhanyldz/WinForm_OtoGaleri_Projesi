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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        DbFirst_OtoGaleriEntities db = new DbFirst_OtoGaleriEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            List<Tbl_Musteri> sayi = db.Tbl_Musteri.OrderBy(x => x.Musteri_AdSoyad).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Tbl_Musteri> sayi = db.Tbl_Musteri.OrderBy(x => x.Musteri_AdSoyad).ToList();
            dataGridView1.DataSource= sayi;

            List<Tbl_Arac> vites = db.Tbl_Arac.OrderBy(y => y.Sanziman).ToList();
            dataGridView1.DataSource = vites;
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
            dataGridView1.DataSource=db.Tbl_Arac.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Tbl_Arac> vites = db.Tbl_Arac.OrderBy(y => y.Sanziman).ToList();
            dataGridView1.DataSource = vites;
        }
    }
}
