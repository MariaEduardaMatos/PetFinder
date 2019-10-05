using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        // definir tamanho do dos campos
        public EnderecoConfig()
        {
            Property(a => a.Cep).HasMaxLength(8);
        }
    }
}
