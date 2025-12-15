using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities;
[Table("DoktorKayit")]
public partial class DoktorKayit
{

    [Key]
    public int HekimId { get; set; }

    public string? Tc { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public DateTime Dogumtarih { get; set; }
    public int Yas { get; set; }
    public string? Telefon { get; set; }

    public int CinsiyetId { get; set; }

    public virtual Cinsiyet Cinsiyet { get; set; }
     
    public virtual ICollection<Misafir> Misafirler { get; set; }
    public virtual ICollection<KabulListe> KabulListeleri { get; set; }
    public virtual ICollection<KayitliKisiListe> KayitliKisiler { get; set; }
    public virtual ICollection<MhrsKayit> MhrsKayitlar { get; set; }
    public virtual ICollection<DoktorKabulDurumu> DoktorKabulDurumlari { get; set; }
    
}
