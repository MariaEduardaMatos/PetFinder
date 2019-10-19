using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.Interfaces
{
    public interface IDbContext
    {
        DbSet<Entity> Set<Entity>() where Entity : class;
        int SaveChanges();
    void Dispose();

    }
}
