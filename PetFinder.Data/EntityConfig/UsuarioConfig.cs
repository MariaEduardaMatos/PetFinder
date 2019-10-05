using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        // definir tamanho do dos campos
        public UsuarioConfig()
        {
            Property(a => a.Telefone).HasMaxLength(20);
            Property(a => a.CPF).HasMaxLength(11);

        }
    }
}
