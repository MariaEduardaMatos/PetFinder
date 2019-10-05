using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class PaisConfig : EntityTypeConfiguration<Pais>
    {
        // definir tamanho do dos campos
        public PaisConfig()
        {
            Property(a => a.Sigla).HasMaxLength(2);
        }
    }
}
