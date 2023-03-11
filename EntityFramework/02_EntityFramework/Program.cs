using _02_EntityFramework.Entites;
using _02_EntityFramework.Operasyon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DBOluşturma
            //Execute.DBOlustur();
            //

            //Execute.VarlikKontrol();


            //Execute.DatabaseSIL();

            #region 2.BÖLÜM CRUD İŞLEMLER
            //User user = new User();
            //user.Surname = "Demirci";
            //user.Username = "sexi_velet_17";
            //user.Name = "Altan Emre";
            //user.Password = "1";
            //Execute.UserEkle(user);


            //Firma F = new Firma();
            //F.Title = "Test A.Ş.";
            //F.PhoneI = "212525555";
            //F.PhoneII = "212525556";
            //F.WebAdress = "www.test.com";
            //F.Email = "info@test.com";

            //int Sonuc = Execute.FirmaEkle(F);


            #region Birden fazla kayıt ekleme işlemi
            //List<Firma> EklenecekFirmalar = new List<Firma>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Firma Frm = new Firma();              
            //    Frm.Title = "Test A.Ş. - " + i.ToString();
            //    Frm.PhoneI = "212525555";
            //    Frm.PhoneII = "212525556";
            //    Frm.WebAdress = "www.test.com";
            //    Frm.Email = "info@test.com";

            //    EklenecekFirmalar.Add(Frm);

            //}

            //Execute.FirmaKayitlarEkle(EklenecekFirmalar);

            #endregion

            #region Bağlı kayıt ekleme işlemi 
            //Kisi K = new Kisi();
            //K.FirmaId = 1;
            //K.Isim = "Ahmet";
            //K.Soyisim = "Yavuz";
            //K.Il = "İstanbul";
            //K.Ilce = "Ümraniye";
            //K.DogumTarihi = DateTime.Parse("04.12.1989");

            //Execute.KisiEkle(K);
            #endregion


            #region FakeData ile Örnek Data Aktarması

            //for (int i = 0; i < 10; i++)
            //{
            //    Firma F = new Firma();
            //    F.Title = FakeData.NameData.GetCompanyName();
            //    F.PhoneI = FakeData.PhoneNumberData.GetPhoneNumber();
            //    F.PhoneII = FakeData.PhoneNumberData.GetPhoneNumber();
            //    F.WebAdress = $"www.{F.Title.ToLower()}.com";
            //    F.Email = $"info@{F.Title.ToLower()}.com";

            //    Execute.FirmaEkle(F);

            //    for (int j = 0; j < 30; j++)
            //    {
            //        Kisi K = new Kisi();
            //        K.FirmaId = F.ID;
            //        K.Isim = FakeData.NameData.GetFirstName();
            //        K.Soyisim = FakeData.NameData.GetSurname();
            //        K.Ulke = FakeData.PlaceData.GetCountry();
            //        K.Il = FakeData.PlaceData.GetCity();
            //        K.Ilce = FakeData.PlaceData.GetCounty();
            //        K.DogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1960, 01, 01), new DateTime(1990, 01, 01));
            //        K.Email = $"{K.Isim}.{K.Soyisim}@{F.Title.ToLower()}.com";
            //        K.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();

            //        Execute.KisiEkle(K);
            //    }
            //}
            #endregion


            #region Kisi Güncelle

            //Execute.KisiGuncelle("Sydney", "Power");
            #endregion

            #region Kisi Sil

            Execute.KisiSil(6);
            #endregion

            #endregion

        }
    }
}
