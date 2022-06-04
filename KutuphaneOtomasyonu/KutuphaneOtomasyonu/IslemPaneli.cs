using KutuphaneOtomasyonu.Kayit;
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
        private KullaniciListeForm klisteForm;
        private void Kullanicibtn_Click(object sender, EventArgs e)
        {

            if (Keklebtn.Visible == false)
            {
                Keklebtn.Visible = true;
                Kduzenbtn.Visible = true;
                Ksilbtn.Visible = true;

                klisteForm= new KullaniciListeForm();
                klisteForm.MdiParent = this;
                klisteForm.Show();
            }

            else

            {
                Keklebtn.Visible = false;
                Kduzenbtn.Visible = false;
                Ksilbtn.Visible = false;

                klisteForm.Close();
            }
        }

        //Kullanici Form Bug Fixes
        private KullaniciEkleForm ekleForm;
        private KullaniciSilForm ksil;
        private KullaniciGuncelleForm kdu;


        private bool ekleKullaniciDurum = false;
        private bool silKullaniciDurum = false;
        private bool KduzenDurum = false;
        //Kullanici Form Bug Fixes end

        private void Keklebtn_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciDurum == false)
            {
                ekleForm = new KullaniciEkleForm();
                ekleForm.MdiParent = this;
                ekleForm.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                ekleForm.Close();
                ekleKullaniciDurum = false;
            }
        }

        private void Ksilbtn_Click(object sender, EventArgs e)
        {
            if (silKullaniciDurum == false)
            {
                ksil = new KullaniciSilForm();
                ksil.MdiParent = this;
                ksil.Show();
                silKullaniciDurum = true;
            }
            else
            {
                ksil.Close();
                silKullaniciDurum = false;
            }
        }

        private void Kduzenbtn_Click(object sender, EventArgs e)
        {
            if (KduzenDurum == false)
            {
                kdu = new KullaniciGuncelleForm();
                kdu.MdiParent = this;
                kdu.Show();
                KduzenDurum = true;
            }
            else
            {
                kdu.Close();
                KduzenDurum = false;
            }
        }
        private KaynakListeForm kListe;
        private void button1_Click(object sender, EventArgs e)
        {
            if (KaynakEkleBtn.Visible == false)
            {

                KaynakEkleBtn.Visible = true;
                KaynakDuzenleBtn.Visible = true;
                KaynakSilBtn.Visible = true;

                kListe = new KaynakListeForm();
                kListe.MdiParent = this;
                kListe.Show();
            }

            else

            {
                KaynakEkleBtn.Visible = false;
                KaynakDuzenleBtn.Visible = false;
                KaynakSilBtn.Visible = false;

                kListe.Close();
            }
        }

        //Kaynak Form Bug Fixes
        private KaynakEkleForm kEkle;
        private KaynakSilForm kSil;
        private KaynakGuncelleForm kGuncel;

        private bool KaynakEkleDurum = false;
        private bool KaynakSilDurum = false;
        private bool KaynakDuzenDurum = false;
        //End

        private void KaynakEkleBtn_Click(object sender, EventArgs e)
        {
            if (KaynakEkleDurum == false)
            {
                kEkle = new KaynakEkleForm();
                kEkle.MdiParent = this;
                kEkle.Show();
                KaynakEkleDurum = true;
            }
            else
            {
                kEkle.Close();
                KaynakEkleDurum = false;
            }
        }

        private void KaynakSilBtn_Click(object sender, EventArgs e)
        {
            if (KaynakSilDurum == false)
            {
                kSil = new KaynakSilForm();
                kSil.MdiParent = this;
                kSil.Show();
                KaynakSilDurum=true;
            }
            else
            {
                kSil.Close();
                KaynakSilDurum = false;
            }
        }

        private void KaynakDuzenleBtn_Click(object sender, EventArgs e)
        {
            if (KaynakDuzenDurum == false)
            {
                kGuncel = new KaynakGuncelleForm();
                kGuncel.MdiParent = this;
                kGuncel.Show();
                KaynakDuzenDurum=true;
            }
            else
            {
                kGuncel.Close();
                KaynakDuzenDurum = false;
            }
        }

        //Ödünç Ver Ve Geri Al Bug Fixes
        private OduncForm odunc;
        private GeriAlForm geriAl;

        private bool OduncDurum = false;
        private bool GeriAlDurum = false;

        //End

        private void button2_Click(object sender, EventArgs e)
        {
            if (OduncDurum == false)
            {
                odunc = new OduncForm();
                odunc.MdiParent = this;
                odunc.Show();
                OduncDurum=true;
            }
            else
            {
                odunc.Close();
                OduncDurum = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GeriAlDurum == false)
            {
                geriAl = new GeriAlForm();
                geriAl.MdiParent = this;
                geriAl.Show();
                GeriAlDurum=true;
            }
            else
            {
                geriAl.Close();
                GeriAlDurum = false;
            }
        }
    }
}
