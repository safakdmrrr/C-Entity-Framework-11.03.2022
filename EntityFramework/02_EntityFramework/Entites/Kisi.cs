using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Entites
{
    public class Kisi
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        // Mapping
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
    }
}
