using _02_EntityFramework.Context;
using _02_EntityFramework.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Operasyon
{
    internal static class Execute
    {
        #region DBOLUŞTURMA
        public static void DBOlustur()
        {
            using (ProjectContext db = new ProjectContext())
            {
                foreach (User item in db.Users.ToList())
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
        #endregion

        #region VARLIKKONTROL
        public static void VarlikKontrol()
        {
            using (ProjectContext db = new ProjectContext())
            {
                if (db.Database.Exists())
                {
                    Console.WriteLine("Database Mevcut.");
                }
                else
                {
                    Console.WriteLine("Database Yok..");
                }
            }
        }
        #endregion

        #region DBSİL
        public static void DatabaseSIL()
        {
            using (ProjectContext db = new ProjectContext())
            {
                if (db.Database.Exists())
                {                    
                    db.Database.Delete();
                }
                else
                {
                    Console.WriteLine("Database Yok..");
                }
            }
        }
        #endregion


        #region C.R.U.D. İşlemleri

        public static void UserEkle(User U)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Users.Add(U);
                //Ekle,Silme,Güncelleme işlemleri data manipülasyonu yapıldığında mutlaka db.SaveChanges(); yazılmalıdır. 
                db.SaveChanges();
            }
        }

        public static int FirmaEkle(Firma F)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Firmalar.Add(F);                
                return db.SaveChanges();
            }
        }

        public static int FirmaKayitlarEkle(List<Firma> Flist)
        {
            
            using (ProjectContext db = new ProjectContext())
            {
                db.Firmalar.AddRange(Flist);
                return db.SaveChanges();
            }
           
        }



        public static void KisiEkle(Kisi K)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Kisiler.Add(K);
                db.SaveChanges();                
            }
        }

        public static void KisiGuncelle(string isim,string soyisim)
        {
            using(var db = new ProjectContext())
            {
                //LINQ to SQL
                //Kisi bulunankisi = (from I in db.Kisiler where I.Isim == isim && I.Soyisim == soyisim select I).FirstOrDefault();

                //LINQ

                Kisi bulunankisi = db.Kisiler.Where(i => i.Isim == isim && i.Soyisim == soyisim).FirstOrDefault();

                if (bulunankisi != null)
                {
                    bulunankisi.Telefon = "2222222222";
                    db.SaveChanges();
                }
            }
        }


        public static void KisiSil(int id)
        {
            using (var db = new ProjectContext())
            {
                //LINQ to SQL
                //Kisi bulunankisi = (from I in db.Kisiler where I.ID==id select I).FirstOrDefault();

                //LINQ

                //Kisi bulunankisi = db.Kisiler.Where(i => i.ID==id).FirstOrDefault();
                Kisi bulunankisi = db.Kisiler.Find(id);

                if (bulunankisi != null)
                {
                    db.Kisiler.Remove(bulunankisi);
                    db.SaveChanges();
                }
            }
        }


        #endregion

    }
}
