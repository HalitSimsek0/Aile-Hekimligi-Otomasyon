using System;
using Entities;

namespace Core.Internal
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<DoktorKayit> DoktorKayitlar { get; }
        IRepository<DoktorKabulDurumu> DoktorKabulDurumlari { get; }
        IRepository<KabulListe> KabulListeleri { get; }
        IRepository<KayitliKisiListe> KayitliKisiListeleri { get; }
        IRepository<MhrsKayit> MhrsKayitlar { get; }
        IRepository<Misafir> Misafirler { get; }
        IRepository<Cinsiyet> Cinsiyetler { get; }
        IRepository<TamamlanmaDurumu> TamamlanmaDurumlari { get; }

        int Commit();
    }
}
