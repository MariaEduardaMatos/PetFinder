using PetFinder.Data.Context;
using PetFinderAplication.AplicationService.Interface;
using PetFinderDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderAplication.AplicationService
{
    public class AppService<TEntity> : IAplicationServices<TEntity>, ItransactionAppService<PetFinderContext> where TEntity : class
    {
        private readonly IService<TEntity> _service;
        public AppService (IService<TEntity> service)
        {
            _service = service;
        }
        public TEntity Add(TEntity obj)
        {
            BeginTransiction();
            _service.Add(obj);
            Commit();
            return obj;
        }

        public void BeginTransiction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int obj)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List List<all>()
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
