using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class RacaConfig : EntityTypeConfiguration<Raca>
    {
        // definir tamanho do dos campos
        public RacaConfig()
        {
            Property(a => a.Descricao).HasMaxLength(500);
        }
    }
}
