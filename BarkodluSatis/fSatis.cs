using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fSatis : Form
    {
        BarkodluDbEntities db = new BarkodluDbEntities();
        public fSatis()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    tMiktar.Text = barkod;
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(x => x.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(x => x.Barkod == barkod).FirstOrDefault();
                        ListeyeUrunGetir(urun, barkod, Convert.ToDouble(tMiktar.Text));
                    }
                    else
                    {
                        int onEk = Convert.ToInt16(barkod.Substring(0, 2));
                        if (db.Terazi.Any(x => x.TeraziOnEk == onEk))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (db.Urun.Any(x => x.Barkod == teraziurunno))
                            {
                                var urunterazi = db.Urun.Where(x => x.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                ListeyeUrunGetir(urunterazi, teraziurunno, miktarkg);
                            }
                            else
                            {
                                MessageBox.Show("Kg ürün ekleme sayfası");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Normal ürün ekleme sayfası");
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();

            }
        }

        private void ListeyeUrunGetir(Urun urun, string barkod, double miktar)
        {
            int satirsayisi = gridSatisListesi.Rows.Count;
            bool eklenmismi = false;

            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                        gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi)
            {
                gridSatisListesi.Rows.Add();
                gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyati;
                gridSatisListesi.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
            }
        }

        private void GenelToplam()
        {
            double toplam = 0;
            for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
            }
            tGenelToplam.Text = toplam.ToString("C2");
            tBarkod.Clear();
            tBarkod.Focus();
        }

        // GridViewList üzerinden tıklanınca silme işlemi
        private void gridSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DialogResult dialogResult = MessageBox.Show("Sütunu silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    gridSatisListesi.Rows.Remove(gridSatisListesi.CurrentRow);
                    gridSatisListesi.ClearSelection();
                    GenelToplam();
                    tBarkod.Focus();
                }
                else
                {
                    tBarkod.Focus();
                }
            }
        }
    }
}
