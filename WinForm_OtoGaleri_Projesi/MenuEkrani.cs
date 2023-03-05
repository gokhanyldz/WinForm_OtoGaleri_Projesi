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
    public partial class MenuEkrani : Form
    {
        public MenuEkrani()
        {
            InitializeComponent();
        }
        private void btn_sube_Click(object sender, EventArgs e)
        {
            Subeler fr=new Subeler();
            fr.Show();
        }

        private void btn_personeller_Click(object sender, EventArgs e)
        {
            Personel ps = new Personel();
            ps.Show();
        }

        private void btn_islemler_Click(object sender, EventArgs e)
        {
            Islem fr= new Islem();
            fr.Show();
        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            Raporlar fr= new Raporlar();
            fr.Show();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            Musteri ms=new Musteri();
            ms.Show();
        }

        private void MenuEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_araclar_Click(object sender, EventArgs e)
        {
            Araclar arc=new Araclar();
            arc.Show();
        }
    }
}
