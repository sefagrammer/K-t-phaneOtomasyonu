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
    public partial class KullaniciGuncelleForm : Form
    {
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Kaditxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Ksoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TCtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Mailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Telefontxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Cezatxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();

            kullanici.kullanici_ad = Kaditxt.Text;
            kullanici.kullanici_soyad = Ksoyadtxt.Text;
            kullanici.kullanici_tc = TCtxt.Text;
            kullanici.kullanici_tel = Telefontxt.Text;
            kullanici.kullanici_mail = Mailtxt.Text;
            kullanici.kullanici_ceza = Convert.ToDouble(Cezatxt.Text);

            db.SaveChanges();
            Listele();
        }

    }
}
