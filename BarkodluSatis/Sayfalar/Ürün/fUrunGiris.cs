using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar.Ürün
{
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            tBarkod.Clear();
            tUrunAdi.Clear();
            tAciklama.Clear();
            tAlisFiyati.Text = "0";
            tSatisFiyati.Text = "0";
            tMiktar.Text = "0";
            tKdvOrani.Text = "8";
        }

        BarkodluDbEntities db = new BarkodluDbEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();

                if (db.Urun.Any(a=>a.Barkod == barkod))
                {
                    var urun = db.Urun.Where(x => x.Barkod == barkod).SingleOrDefault();
                    tUrunAdi.Text = urun.UrunAd;
                    tAciklama.Text = urun.Aciklama;
                    cmbUrunGrubu.Text = urun.UrunGrup;
                    tAlisFiyati.Text = urun.AlisFiyati.ToString();
                    tSatisFiyati.Text = urun.SatisFiyat.ToString();
                    tMiktar.Text = urun.Miktar.ToString();
                    tKdvOrani.Text = urun.KdvOrani.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değil kaydedebilirsiniz");
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tBarkod.Text != "" && tUrunAdi.Text != "" && cmbUrunGrubu.Text != "" && tAlisFiyati.Text!="" && tSatisFiyati.Text != "" && tKdvOrani.Text != "" && tMiktar.Text !="")
            {
                if (db.Urun.Any(x=>x.Barkod == tBarkod.Text))
                {
                    var guncelle = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();

                    guncelle.Barkod = tBarkod.Text;
                    guncelle.UrunAd = tUrunAdi.Text;
                    guncelle.Aciklama = tAciklama.Text;
                    guncelle.UrunGrup = cmbUrunGrubu.Text;
                    guncelle.AlisFiyati = Convert.ToDouble(tAlisFiyati.Text);
                    guncelle.SatisFiyat = Convert.ToDouble(tSatisFiyati.Text);
                    guncelle.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    guncelle.KdvTutari = Math.Round(Islemler.Double.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tMiktar.Text);
                    guncelle.Birim = "Adet";
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lKullanici.Text;

                    db.SaveChanges();
                    gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(10).ToList();
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = tBarkod.Text;
                    urun.UrunAd = tUrunAdi.Text;
                    urun.Aciklama = tAciklama.Text;
                    urun.UrunGrup = cmbUrunGrubu.Text;
                    urun.AlisFiyati = Convert.ToDouble(tAlisFiyati.Text);
                    urun.SatisFiyat = Convert.ToDouble(tSatisFiyati.Text);
                    urun.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    urun.KdvTutari = Math.Round(Islemler.Double.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tMiktar.Text);
                    urun.Birim = "Adet";
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lKullanici.Text;

                    db.Urun.Add(urun);
                    db.SaveChanges();

                    Temizle();

                    gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(10).ToList();
                }
               

                
            }
            else
            {
                MessageBox.Show("Bilgi işlerini kontrol ediniz");
                tBarkod.Focus();
            }
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(10).ToList();

            tUrunSayisi.Text = db.Urun.Count().ToString();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length>=2)
            {
                string urunAd = tUrunAra.Text;
                gridUrunler.DataSource = db.Urun.Where(x => x.UrunAd.Contains(urunAd)).ToList();
            }
        }

        private void tUrunAra_Leave(object sender, EventArgs e)
        {
            tUrunAra.Clear();
            gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(10).ToList();
        }

        

        private void bIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        
    }
}
