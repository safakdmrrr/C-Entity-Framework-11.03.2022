using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Entites
{
    public class User
    {
        //bir property adı ID,id,Id,iD vb. olması durumunda EF direk o property kolon haline getirirken Primary Key ve Identity özellikleri verir.
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
