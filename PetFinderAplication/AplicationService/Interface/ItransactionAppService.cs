using PetFinder.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderAplication.AplicationService.Interface
{
   public interface ItransactionAppService <TContext> where TContext : IDbContext, new()
    {
        void BeginTransiction();
        void Commit();
    }
}
