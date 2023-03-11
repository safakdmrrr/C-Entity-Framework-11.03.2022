using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EntityFramework.Entites
{
    [Table("Firmalar")]
    public class Firma
    {
        public int ID { get; set; }
        [StringLength(30)]
        [Required]
        public string Title { get; set; }
        public string PhoneI { get; set; }
        public string PhoneII { get; set; }
        public string WebAdress { get; set; }
        public string Email { get; set; }

        // one to many 1-N
        public List<Kisi> Kisis { get; set; }
    }
}
