using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Islemler
{
    public class Komisyon
    {
        public static int KartKomisyon()
        {
            int sonuc = 0;
            using (var db = new BarkodluDbEntities())
            {
                if (db.Sabit.Any())
                {
                    sonuc =Convert.ToInt16(db.Sabit.First().KartKomisyon);
                }
                else
                {
                    sonuc = 0;
                }
            }
            return sonuc;
        }
    }
}
