using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        // definir tamanho do dos campos
        public EstadoConfig()
        {
            Property(a => a.Uf).HasMaxLength(2);
        }
    }
}
