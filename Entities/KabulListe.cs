using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;
[Table("KabulListe")]
public partial class KabulListe
{
    [Key]
    public int KabulId { get; set; }

    public string? Tc { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public DateTime Dogumtarih { get; set; }
    public int Yas { get; set; }

    public int TamamlanmaDurumuId { get; set; }
    public virtual TamamlanmaDurumu TamamlanmaDurumu { get; set; }

    public int HekimId { get; set; }
    public virtual DoktorKayit Hekim { get; set; }
    public bool OncelikliMi { get; set; }
}
