using KutuphaneOtomasyonu.Kaynak;
using KutuphaneOtomasyonu.Kullanıcı;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            // Kullanıcı Butonları
            Keklebtn.Visible = false;
            Kduzenbtn.Visible = false;
            Ksilbtn.Visible = false;

            //Kaynak Butonları
            KaynakEkleBtn.Visible = false;
            KaynakDuzenleBtn.Visible = false;
            KaynakSilBtn.Visible = false;


        }

        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            if (Keklebtn.Visible == false)
            {

                Keklebtn.Visible = true;
                Kduzenbtn.Visible = true;
                Ksilbtn.Visible = true;

            }

            else

            {
                Keklebtn.Visible = false;
                Kduzenbtn.Visible = false;
                Ksilbtn.Visible = false;
                
            }

            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show();
        }

        private void Keklebtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void Ksilbtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm ksil = new KullaniciSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void Kduzenbtn_Click(object sender, EventArgs e)
        {
           KullaniciGuncelleForm kdu = new KullaniciGuncelleForm();
           kdu.MdiParent = this;
           kdu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KaynakEkleBtn.Visible == false)
            {

                KaynakEkleBtn.Visible = true;
                KaynakDuzenleBtn.Visible = true;
                KaynakSilBtn.Visible = true;

            }

            else

            {
                KaynakEkleBtn.Visible = false;
                KaynakDuzenleBtn.Visible = false;
                KaynakSilBtn.Visible = false;

            }

            KaynakListeForm kListe = new KaynakListeForm();
            kListe.MdiParent = this;
            kListe.Show();
        }

        private void KaynakEkleBtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kEkle = new KaynakEkleForm();
            kEkle.MdiParent = this;
            kEkle.Show();
        }
    }
}
