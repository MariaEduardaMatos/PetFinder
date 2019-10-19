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
    public class RacaService : Services<Raca>, IRacaService
    {
        private readonly IRacaService _petRepository;
        public RacaService(IRacaRepository repository) : base(repository)
        {
            _IracaRepository = repository; 
        }

    }
}
