using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Kaydı
{
    public class SeedMethod : System.Data.Entity.DropCreateDatabaseIfModelChanges<Model1>
    {
        protected override void Seed(Model1 context)
        {
            var ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci { OgrID=14,AdSoyad="Kerem Can KURT",Sehir="Ankara"},
                new Ogrenci { OgrID=47,AdSoyad="Emirhan YAMAN",Sehir="İstanbul" },
                new Ogrenci { OgrID=42,AdSoyad="Emir Kılıçkaya",Sehir="İstanbul" }

            };
            ogrenciler.ForEach(s => context.ogrenciler.Add(s));
            context.SaveChanges();
        }
    }
}
