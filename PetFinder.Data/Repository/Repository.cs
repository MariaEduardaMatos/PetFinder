using PetFinder.Data.Interfaces;
using PetFinderDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Repository
{
    public class Repository<Entity> : IRepository<Entity>, IDisposable where Entity : class
    {
        private readonly IDbContext _dbContext;
        private readonly IDbSet<Entity> _dbSet;
        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Entity>();
        }
        public Entity Add(Entity obj)
        {
            _dbSet.Add(obj);
            return obj;
        }


        public void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
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
