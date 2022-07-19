using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Islemler
{
    static class Stok
    {
        public static void StokAzalt(string barkod, double miktar)
        {
            if (barkod != "111111111116")
            {
                using (var db = new BarkodluDbEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }

        public static void StokArtır(string barkod, double miktar)
        {
            if (barkod != "111111111116")
            {
                using (var db = new BarkodluDbEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar += miktar;
                    db.SaveChanges();
                }
            }
        }
    }
}
