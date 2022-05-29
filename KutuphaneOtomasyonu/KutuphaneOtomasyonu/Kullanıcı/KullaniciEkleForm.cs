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
