using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kaynak
{
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();    
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenkaynak = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var guncelkaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenkaynak).FirstOrDefault();
            guncelkaynak.kaynak_ad = adKaynaktxt.Text;
            guncelkaynak.kaynak_yazar = yazarKaynaktxt.Text;
            guncelkaynak.kaynak_yayıncı = yayinciKaynaktxt.Text;
            guncelkaynak.kaynak_sayfasayısı = Convert.ToInt16(numericUpDown1.Value);
            guncelkaynak.kaynak_basımtarihi = dateTimePicker1.Value;
            db.SaveChanges();


            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}
