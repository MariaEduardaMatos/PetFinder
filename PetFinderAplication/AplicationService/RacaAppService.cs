using PetFinderDomain.Entities;
using PetFinderDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderAplication.AplicationService
{
    public class RacaAppService :AppService<Raca>
    {
        public RacaAppService(IRacaService service) : base(service)
        {

        }
    }
}
