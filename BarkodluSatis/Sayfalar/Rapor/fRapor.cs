using BarkodluSatis.Islemler;
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

namespace BarkodluSatis.Sayfalar.Rapor
{
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        public void bGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime baslangic = DateTime.Parse(dateBaslangicTarih.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dateBitisTarih.Value.ToShortDateString());
            bitis = bitis.AddDays(1);

            using (var db = new BarkodluDbEntities())
            {
                if (listFiltrelemeTuru.SelectedIndex == 0) // Tümünü Getir
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();

                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;

                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false).Load();
                    var satisTablosu = db.Satis.Local.ToBindingList();
                    double kdvTutariSatis = Islemler.Double.DoubleYap(satisTablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvTutariIade = Islemler.Double.DoubleYap(satisTablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    tKdvToplam.Text = (kdvTutariSatis - kdvTutariIade).ToString("C2");


                }

                else if (listFiltrelemeTuru.SelectedIndex == 1) // Sadece Satışlar
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }

                else if (listFiltrelemeTuru.SelectedIndex == 2) // Sadece İadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }

                else if (listFiltrelemeTuru.SelectedIndex == 3) // Sadece Gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }

                else if (listFiltrelemeTuru.SelectedIndex == 4) // Sadece Giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource = islemozet;
                }

                else
                {
                    MessageBox.Show("Lütfen listeden işlem türü seçiniz", "Uyarı");
                }
            }

            gridDataViewDuzenle.GridDuzenle(gridListe);
            Cursor.Current = Cursors.Default;

            //LabelTarih();
        }

        //public void LabelTarih()
        //{
        //    DateTime baslangicTarih = DateTime.Parse(dateBaslangicTarih.Value.ToString("dd.MMMM.yyyy"));
        //    DateTime bitisTarih = DateTime.Parse(dateBitisTarih.Value.ToString("dd.MMMM.yyyy"));

        //    lTarih.Text = baslangicTarih + " - " + bitisTarih + " tarihleri arasındaki tümü listelendi";
        //}

        private void fRapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text = Islemler.Komisyon.KartKomisyon().ToString("C2");
            bGoster_Click(null, null);

            //LabelTarih();

        }

        private void gridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.GelirGider = "Gelir";
            f.Kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.GelirGider = "Gider";
            f.Kullanici = lKullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListe.Rows.Count>0)
            {
                int islemno = Convert.ToInt32(gridListe.CurrentRow.Cells["IslemNo"].Value.ToString());
                DateTime tarih = Convert.ToDateTime(gridListe.CurrentRow.Cells["Tarih"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGoster f = new fDetayGoster();
                    f.IslemNo = islemno;
                    f.Tarih = tarih;
                    f.ShowDialog();
                }
            }
        }
    }
}
