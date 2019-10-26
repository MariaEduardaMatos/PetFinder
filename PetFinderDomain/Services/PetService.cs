using PetFinderDomain.Entities;
using PetFinderDomain.Interfaces.Repository;
using PetFinderDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Services
{
    public class PetService : Services<Pet>, IPetService
    {
        private readonly IPetService _petRepository;
        public PetService(IPetReposity repository) : base(repository)
        {
            _petRepository = repository;

        }

    }
}
