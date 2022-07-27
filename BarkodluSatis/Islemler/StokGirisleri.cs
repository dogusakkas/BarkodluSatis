using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Islemler
{
    public class StokGirisleri
    {
        public static void StokHareket(string barkod, string urunAd, string birim, double miktar, string urunGrup, string kullanici)
        {
            using (var db = new BarkodluDbEntities())
            {
                StokHareket sh = new StokHareket();
                sh.Barkod = barkod;
                sh.UrunAd = urunAd;
                sh.Birim = birim;
                sh.Miktar = miktar;
                sh.UrunGrup = urunGrup;
                sh.Kullanici = kullanici;
                sh.Tarih = DateTime.Now;

                db.StokHareket.Add(sh);
                db.SaveChanges();
            }
        }
    }
}
