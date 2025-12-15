using Core.Internal;
using DataAccess.Generic;
using Entities;

namespace DataAccess.UnitOfWorkConcrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbCon _context;

        public UnitOfWork(AppDbCon context)
        {
            _context = context;
        }

        private IRepository<DoktorKayit> _doktorKayitlar;
        private IRepository<DoktorKabulDurumu> _doktorKabulDurumlari;
        private IRepository<KabulListe> _kabulListeleri;
        private IRepository<KayitliKisiListe> _kayitliKisiListeleri;
        private IRepository<MhrsKayit> _mhrsKayitlar;
        private IRepository<Misafir> _misafirler;
        private IRepository<Cinsiyet> _cinsiyetler;
        private IRepository<TamamlanmaDurumu> _tamamlanmaDurumlari;

        public IRepository<DoktorKayit> DoktorKayitlar =>
            _doktorKayitlar ??= new GenericRepository<DoktorKayit>(_context);

        public IRepository<DoktorKabulDurumu> DoktorKabulDurumlari =>
            _doktorKabulDurumlari ??= new GenericRepository<DoktorKabulDurumu>(_context);

        public IRepository<KabulListe> KabulListeleri =>
            _kabulListeleri ??= new GenericRepository<KabulListe>(_context);

        public IRepository<KayitliKisiListe> KayitliKisiListeleri =>
            _kayitliKisiListeleri ??= new GenericRepository<KayitliKisiListe>(_context);

        public IRepository<MhrsKayit> MhrsKayitlar =>
            _mhrsKayitlar ??= new GenericRepository<MhrsKayit>(_context);

        public IRepository<Misafir> Misafirler =>
            _misafirler ??= new GenericRepository<Misafir>(_context);

        public IRepository<Cinsiyet> Cinsiyetler =>
            _cinsiyetler ??= new GenericRepository<Cinsiyet>(_context);

        public IRepository<TamamlanmaDurumu> TamamlanmaDurumlari =>
            _tamamlanmaDurumlari ??= new GenericRepository<TamamlanmaDurumu>(_context);

        public int Commit() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
