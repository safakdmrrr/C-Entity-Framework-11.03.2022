using _02_EntityFramework.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Context
{
    internal class ProjectContext : DbContext
    {
        #region 1.Connection Yöntemi

        public ProjectContext() : base(@"Server=DESKTOP-G08N4IE\SQLDERS; Database=Sirket; uid=sa; pwd=1")       
        {

        }
        #endregion

        #region 2.Connection Yöntemi
        //public ProjectContext()
        //{
        //    Database.Connection.ConnectionString = @"Server=DESKTOP-G08N4IE\SQLDERS; Database=Müşteriler; uid=sa; pwd=1";
        //}

        #endregion

        #region 3.Connection Yöntemi
        //public ProjectContext() : base("MSSQL")
        //{
        //    //App.config içerisinde configurations tag leri arasına connectionStrings tagleri açıldı ve connection tanımlaması yapıldı.Bağlantıya verilen isim ProjectContext classının constructor methoduna base ile tanımladı.
        //}
        #endregion


        public DbSet<User> Users { get; set; } //Class isminin sonuna 's' eklenir. Pluraze işlemi denir ama istenilen isim yazılabilir.

        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }

        /*
        0-Tools=>NugetPackageManager=>ManageNugetPackageforSolutions=>Browse=>Entity Framework
        1-User class oluşturuldu.
        2-ProjectContext class açıldı 3 farklı connection yazıldı.
        3-
         */
    }
}
