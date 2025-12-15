using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;
[Table("DoktorKabulDurumu")]
public partial class DoktorKabulDurumu
{
    [Key]
    public int DoktorKabulDurumuId { get; set; }

    public int HekimId { get; set; }
    public virtual DoktorKayit? Hekim { get; set; }

    public int AlinanKabulSayisi { get; set; }
    public int MisafirKabulSayisi { get; set; }
    public int ToplamKayitliHastaSayisi { get; set; }
}
