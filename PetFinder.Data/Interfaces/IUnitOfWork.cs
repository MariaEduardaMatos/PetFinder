using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        void BeginTransaction();
        void SaveChages();
        void Rollback();
    }
}
