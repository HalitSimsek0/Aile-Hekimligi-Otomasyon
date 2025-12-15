using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("KayitliKisiListesi")]
public class KayitliKisiListe
{
    [Key]
    public int KayId { get; set; }

    public string? Tc { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public DateTime Dogumtarih { get; set; }
    public string? AnneAd { get; set; }
    public int Yas { get; set; }
    public string? BabaAd { get; set; }
    public string? Telefon { get; set; }

    public int HekimId { get; set; }
    public virtual DoktorKayit? Hekim { get; set; }
}
