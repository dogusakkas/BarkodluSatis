using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar
{
    public partial class fHizliButonUrunEkle : Form
    {
        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        BarkodluDbEntities db = new BarkodluDbEntities();
        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text != null)
            {
                string urunad = tUrunAra.Text;
                var urunler = db.Urun.Where(x => x.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
            }
        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                int urunId = Convert.ToInt16(lblButonId.Text);
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunAd = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                var guncellenecek = db.HizliUrun.Find(urunId);

                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunAd;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton Tanımlanmıştır", "Başarılı", MessageBoxButtons.OK);

                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bHizli" + urunId, true).FirstOrDefault() as Button;
                    b.Text = urunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                gridUrunler.DataSource = db.Urun.ToList();
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }
    }
}
