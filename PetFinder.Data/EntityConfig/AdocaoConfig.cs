using PetFinderDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinder.Data.EntityConfig
{
    public class AdocaoConfig : EntityTypeConfiguration<Adocao>
    {
        // definir tamanho do dos campos
        public AdocaoConfig()
        {

            HasRequired(a => a.Doador)
                .WithMany()
                .HasForeignKey(a => a.DoadorId);
        }
    }
}
