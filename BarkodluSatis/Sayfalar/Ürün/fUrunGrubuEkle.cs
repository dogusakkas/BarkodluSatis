using BarkodluSatis.Sayfalar.Ürün;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar.Satış
{
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAdi";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(x => x.UrunGrupAdi).ToList();
        }

        BarkodluDbEntities db = new BarkodluDbEntities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text != "")
            {
                UrunGrup urunGrup = new UrunGrup();
                urunGrup.UrunGrupAdi = tUrunGrupAd.Text;
                db.UrunGrup.Add(urunGrup);
                db.SaveChanges();

                GrupDoldur();
                tUrunGrupAd.Clear();

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
            }
            else
            {
                MessageBox.Show("Grup bilgisi ekleyiniz", "Uyarı", MessageBoxButtons.OK);
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupId = Convert.ToInt16(listUrunGrup.SelectedValue.ToString());
            string grupAd = listUrunGrup.Text;

            DialogResult dialogResult = MessageBox.Show(grupAd + " grubu silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x=>x.Id ==grupId);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupAd +" ürün grubu silindi");

                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.GrupDoldur();
            }
        }
    }
}
