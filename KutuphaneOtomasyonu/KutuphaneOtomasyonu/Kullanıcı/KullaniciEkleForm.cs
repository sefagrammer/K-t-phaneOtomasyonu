using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kullanıcı
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        public void Listele()
        {
            KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();

            // Kolonlar Gizlendi
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            //Kolon Adları Düzenlendi
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "SoyAd";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[6].HeaderText = "Ceza";
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = Kaditxt.Text;
            kullanicilar.kullanici_soyad = Ksoyadtxt.Text;
            kullanicilar.kullanici_tc = TCtxt.Text;
            kullanicilar.kullanici_tel = Telefontxt.Text;
            kullanicilar.kullanici_mail = Mailtxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(Cezatxt.Text);

            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }
    }
}
