using BarkodluSatis.Sayfalar.Satış;
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

                    if (tBarkod.Text.Length==8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges();
                    }

                    gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(20).ToList();
                    Islemler.gridDataViewDuzenle.GridDuzenle(gridUrunler);
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

                    gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(20).ToList();
                    Islemler.gridDataViewDuzenle.GridDuzenle(gridUrunler);
                }
               

                
            }
            else
            {
                MessageBox.Show("Bilgi işlerini kontrol ediniz");
                tBarkod.Focus();
            }
        }

        public void GrupDoldur()
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAdi";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrup.OrderBy(x => x.UrunGrupAdi).ToList();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(20).ToList();
            Islemler.gridDataViewDuzenle.GridDuzenle(gridUrunler);

            tUrunSayisi.Text = db.Urun.Count().ToString(); // dataGridViewdeki ürünlerin sayısı

            GrupDoldur();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length>=2)
            {
                string urunAd = tUrunAra.Text;
                gridUrunler.DataSource = db.Urun.Where(x => x.UrunAd.Contains(urunAd)).ToList();

                Islemler.gridDataViewDuzenle.GridDuzenle(gridUrunler);
            }
        }

        private void tUrunAra_Leave(object sender, EventArgs e)
        {
            tUrunAra.Clear();
            gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(20).ToList(); // Ürün ara textboxından farklı bir yere tıklanırsa dataGridView tablosunu eski haline getirir
        }

        

        private void bIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle uge = new fUrunGrubuEkle();
            uge.ShowDialog();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;

            for (int i = 0; i < 8-karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            tBarkod.Text = olusanbarkod;

            tUrunAdi.Focus();
        }

        // Alış fiyatı ve Satış fiyatı her ikisi içinde geçerli
        private void tAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunler.Rows.Count>0)
            {
                int urunId = Convert.ToInt32(gridUrunler.CurrentRow.Cells["Id"].Value.ToString());
                string urunAd = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(urunAd + " ürünü silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    var urun = db.Urun.Find(urunId);
                    db.Urun.Remove(urun);
                    
                    var hizliurun = db.HizliUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                    hizliurun.Barkod = "-";
                    hizliurun.UrunAd = "-";
                    hizliurun.Fiyat = 0;
                    db.SaveChanges();

                    MessageBox.Show("Ürün başarıyla silindi");

                    gridUrunler.DataSource = db.Urun.OrderByDescending(x => x.Id).Take(20).ToList();
                    Islemler.gridDataViewDuzenle.GridDuzenle(gridUrunler);

                    tBarkod.Focus();
                }
            }
           
        }
    }
}
