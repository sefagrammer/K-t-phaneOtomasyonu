using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form   
    {
        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenAd = Kaditxt.Text;
            string gelenSifre = loginsifretxt.Text;

            var personel = db.PersonelTable.Where(x => x.personel_kullaniciadi.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

            else
            { 
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
