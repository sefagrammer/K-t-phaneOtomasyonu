﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kayit
{
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            //Kolonlar Gizlendi
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //Kolonlar Adlandırıldı
            dataGridView1.Columns[1].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[2].HeaderText = "Kaynak ID";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "İade Tarihi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitid = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.kayit_id == secilenKayitid).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }
    }
}
