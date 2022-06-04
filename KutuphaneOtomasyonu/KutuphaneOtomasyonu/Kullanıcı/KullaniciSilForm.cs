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
  
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }
         
        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();
        public void Listele()
             
        {

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

        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
              Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult silinsinMi = MessageBox.Show("Kullanıcıyı Silmek İstediğine Emin Misin ?",
                "Silme İşlemi",MessageBoxButtons.YesNo);

            if( silinsinMi == DialogResult.Yes )
            {
                int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
                db.Kullanicilar.Remove(kullanici);
                db.SaveChanges();
                Listele();
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }
        }
    }
}
