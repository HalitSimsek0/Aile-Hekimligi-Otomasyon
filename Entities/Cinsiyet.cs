using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Cinsiyet")]
    public class Cinsiyet
    {
        [Key]
        public int CinsiyetId { get; set; }     
        public string CinsiyetAdi { get; set; }  
        public virtual ICollection<DoktorKayit> Doktorlar { get; set; }
       
    }
}
