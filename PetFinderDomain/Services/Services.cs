using PetFinderDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Services
{
    public class Services<Entity> : IService <Entity> where Entity : class
    {
        private readonly IRepository<Entity> _repository;
        public Services(IRepository<Entity>repository)
        {
            _repository = repository;
        }
        public Entity Add (Entity obj)
        {
            _repository.Add(obj);
            return obj;
        }
        public Entity Get (int id)
        {
            return _repository.Get(id);
        }
        public List<Entity> ListAll()
        {
            return _repository.ListAll();
        }
        public void Delete (int id)
        {
            _repository.Delete(id);
        }
        Entity IService<Entity>.Update(Entity obj)
        {
            return _repository.Update(obj);
        }
    }
}
