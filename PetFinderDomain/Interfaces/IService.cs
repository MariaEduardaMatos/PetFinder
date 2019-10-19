using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Get(int obj);
        TEntity Update(TEntity obj);
       void Delete(int obj);
        List<TEntity> ListAll();
    }
}
