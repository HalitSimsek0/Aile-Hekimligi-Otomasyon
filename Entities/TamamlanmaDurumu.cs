using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("TamamlanmaDurumu")]
    public class TamamlanmaDurumu
    {
        [Key]
        public int TamamlanmaDurumuId { get; set; }
        public string? DurumAdi { get; set; }
        public virtual ICollection<KabulListe> KabulListeleri { get; set; }
    }
}
