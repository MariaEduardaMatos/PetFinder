using PetFinder.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data
{
    public class UnitOfWork<TContext> : UnitOfWork<Context>, IDisposable where TContext : DbContext, new()
    {

        private readonly IDbContext _dbContext;
        private bool _disposed;
        

        public UnitOfWork(DbContext dbcontext)
        {
            _dbcontext = dbContext;
            
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public Entity Add(Entity obj)
        {
            
        }
        public void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int obj)
        {
            throw new NotImplementedException();
        }

        public List<Entity> ListAll()
        {
            throw new NotImplementedException();
        }

        public Entity Update(Entity obj)
        {
            throw new NotImplementedException();
        }

    }
}
