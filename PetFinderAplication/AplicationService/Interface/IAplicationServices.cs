using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderAplication.AplicationService.Interface
{
    public interface IAplicationServices <TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Get(int obj);
        TEntity Update(TEntity obj);
        List List <all>();
        void (TEntity obj);

    }
}
