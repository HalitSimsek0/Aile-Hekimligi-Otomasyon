using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IkisiServis
    {
        IEnumerable<KayitliKisiListe> GetAll();
        KayitliKisiListe GetById(int id);
        void Add(KayitliKisiListe kisi);
        void Update(KayitliKisiListe kisi);
        void Delete(int id);
    }
}
