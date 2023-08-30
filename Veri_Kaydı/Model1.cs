using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Veri_Kaydı
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Veri_Kaydı.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }
        public DbSet<Ogrenci> ogrenciler { get; set; }
    }
    public class Ogrenci
    {
        [Key]
        public int ID { get; set; }
        public int OgrID { get; set; }
        public string AdSoyad { get; set; }
        public string Sehir { get; set; }
    }

}