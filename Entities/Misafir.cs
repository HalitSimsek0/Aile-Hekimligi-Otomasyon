using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Misafir")]
    public class Misafir
    {
        [Key]
        public int MisafirId { get; set; }
        public string? Tc { get; set; }

        public int HekimId { get; set; }
      
        public virtual DoktorKayit Hekim { get; set; }
        
    }
}
