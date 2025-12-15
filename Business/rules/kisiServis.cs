using Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Entities;

namespace Business
{
    public class kisiServis : IkisiServis
    {
        private readonly IUnitOfWork _unitOfWork;
        public kisiServis(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<KayitliKisiListe> GetAll() => _unitOfWork.KayitliKisiListeleri.GetAll();
        public KayitliKisiListe GetById(int id) => _unitOfWork.KayitliKisiListeleri.GetById(id);
        public void Add(KayitliKisiListe kisi)
        {
            _unitOfWork.KayitliKisiListeleri.add(kisi);
            _unitOfWork.Commit();
        }
        public void Update(KayitliKisiListe kisi)
        {
            _unitOfWork.KayitliKisiListeleri.Update(kisi);
            _unitOfWork.Commit();
        }
      public IEnumerable<KayitliKisiListe> Find(System.Linq.Expressions.Expression<Func<KayitliKisiListe, bool>> predicate)
        {
            return _unitOfWork.KayitliKisiListeleri.Find(predicate);
        }
        public void Delete(int id)
        {
            _unitOfWork.KayitliKisiListeleri.Delete(id);
            _unitOfWork.Commit();


        }
    }
}