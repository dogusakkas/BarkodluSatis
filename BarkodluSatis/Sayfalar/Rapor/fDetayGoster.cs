using BarkodluSatis.Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar.Rapor
{
    public partial class fDetayGoster : Form
    {
        public fDetayGoster()
        {
            InitializeComponent();
        }

        public int IslemNo { get; set; }
        public DateTime Tarih { get; set; }

        private void fDetayGoster_Load(object sender, EventArgs e)
        {
            lIslemNo.Text = IslemNo.ToString();
            lTarih.Text = Tarih.ToString();
            using (var db = new BarkodluDbEntities())
            {
                gridListe.DataSource = db.Satis.Select(y=> new { y.IslemNo, y.UrunAd, y.UrunGrup, y.Miktar, y.KdvTutari, y.Toplam}).Where(x => x.IslemNo == IslemNo).ToList();

                gridDataViewDuzenle.GridDuzenle(gridListe);
            }
        }
    }
}
