using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar.Stok
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;

            using (var db = new BarkodluDbEntities())
            {
                if (cmbIslemTuru.Text != "")
                {
                    string urungrubu = cmbUrunGrubu.Text;

                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rbTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if (rbUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }

                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }
                    }

                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangic = DateTime.Parse(dateBaslangicTarih.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dataBitisTarih.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);

                        if (rbTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }

                        else if (rbUrunGrubunaGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }

                        else
                        {
                            MessageBox.Show("Lütfen filtreleme türünü seçiniz");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen işlem türünü seçiniz");
                }
            }

            Islemler.gridDataViewDuzenle.GridDuzenle(gridListe);
        }

        BarkodluDbEntities db = new BarkodluDbEntities();

        private void fStok_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAdi";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >=2)
            {
                string urunad = tUrunAra.Text;

                using (var db = new BarkodluDbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
            }
            Islemler.gridDataViewDuzenle.GridDuzenle(gridListe);
        }
    }
}
