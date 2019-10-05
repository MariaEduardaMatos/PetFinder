using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class PetConfig:EntityTypeConfiguration<Pet>
    {
        // definir tamanho do dos campos
        public PetConfig()
        {
            HasKey(a => a.PetId);// se for utilizar uma nomenclatura diferente
            Property(a => a.Observacao).HasMaxLength(500);
        }
    }
}
