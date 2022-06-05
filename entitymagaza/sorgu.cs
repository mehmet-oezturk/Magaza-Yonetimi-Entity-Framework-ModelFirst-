using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitymagaza
{
    class sorgu
    { public void silme(int a)
        {

        }
        magazaEntities1 baglanti = new magazaEntities1();
      public  bool KullaniciGiris(string ad, string sifre)
        {
       var sorgu = from p in baglanti.kullanicilar
                    where p.KullaniciAd == ad && p.Sifre == sifre
                    select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     
    }
}
