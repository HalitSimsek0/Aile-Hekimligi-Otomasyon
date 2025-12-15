using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;
[Table("MhrsKayit")]
public partial class MhrsKayit
{
    [Key]
    public int MhrsId { get; set; }

    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public string? Tc { get; set; }
    public TimeSpan Saat { get; set; }
    public DateTime Tarih { get; set; }

    public int HekimId { get; set; }
    public virtual DoktorKayit? Hekim { get; set; }
}
