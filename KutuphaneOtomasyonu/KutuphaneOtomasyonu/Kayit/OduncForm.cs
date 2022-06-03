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
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }
        
        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        private void OduncForm_Load(object sender, EventArgs e)
        { 
            // Listeleme (Kayitlar)
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            // Listeleme (Kaynaklar)
            var kaynakList = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            //Gereksiz Yazıları Gizleme
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //Kolon Adları Düzenlendi
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = TCbultxt.Text;
            var KullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (KullaniciVarMi != null)
                label2.Text = KullaniciVarMi.kullanici_ad + " " + KullaniciVarMi.kullanici_soyad;

            else
                label2.Text = "Böyle Bir Kullanıcı Bulunmamaktadır!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kişiyi Çağırdık
            string secilenKisiTC = TCbultxt.Text;
            var secilenKisi = db.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();

            //Kaynağı Çağırdık
            int secilenKaynakId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenKaynakId).FirstOrDefault();

            Kayitlar yeniKayit = new Kayitlar();
            yeniKayit.kitap_id = secilenKaynak.kaynak_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarih = DateTime.Today;
            yeniKayit.teslim_tarih = DateTime.Today.AddDays(15);
            yeniKayit.durum = false;
            db.Kayitlar.Add(yeniKayit);
            db.SaveChanges();

            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }
    }
}
