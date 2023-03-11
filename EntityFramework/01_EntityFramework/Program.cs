using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO.NET
            //SqlDataReader reader;

            //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G08N4IE\SQLDERS; Initial Catalog=Customers; Integrated Security=true");

            //connect.Open();

            //Console.WriteLine("Bağlantı Sağlandı.");

            //SqlCommand command = new SqlCommand("Select * from Customers", connect);

            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader.GetInt32(0).ToString());
            //    Console.WriteLine(reader.GetString(1));
            //}
            //reader.Close();
            //connect.Close();
            #endregion


            /* ENTITY FRAMEWORK
                C# ile SQL dillerini bağlar ve SQL sorgulama diline ait komutların SSQL yazılımına gitmeden C# kodları arasında yazılmasını sağlayan framework'tür. En büyük avantajı Veritabanı ile ilgili bitin işleri daha anlaşılır ve kolay bir komut yazpısıyla gerçekleştirir. 
            
            
             1-) Tools => Nuget Package Manager => Entity Framework kuruyoruz.
             2-) Customer class oluşturdum.
             3-) DatabasseContext class açtım ve EF den dahil olan DbContext inharitance ettim.
             4-) Constructor Method üzerinden database Connection tanımlandı.
             5-) Hangi classların DB de set edilmesini(tablo olmasını) istiyorsan onaları DBSet ile tanımladım.
             6-) Projenin içerisinde Database set edilen bir class üzerinde işlem yapıldığında DATABASE-TABLOLAR VE İLİŞKİLER VERİTABANINA AKTARILIR.
                

            ** ORM(Object Relation Mapping) 

            Veritabanımızda oluşturduğumuz ve uygulama içerisinde kullanacağımız her bir nesnemizin uygulama karşılığına ORM denir.

            ** OOP(Object Oriented Programming) **

            Nesne Yönelimli programlama, uygulamalarımızı yazarken katmanlardan faydalanma
             
            ** EF ÇEŞİTLERİ **
            1-) Code First
            2-) Model First
            3-) Database First
            4-) Code First(Var olan DB)


            
             */






            DatabasContext db = new DatabasContext();

            db.Customers.ToList();

            Console.ReadLine();
        }
    }

    class DatabasContext:DbContext
    {
        public DatabasContext():base(@"Server=DESKTOP-G08N4IE\SQLDERS; Database=Müşteriler; uid=sa; pwd=1")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }

    
}
