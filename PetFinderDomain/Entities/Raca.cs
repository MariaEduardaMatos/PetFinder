using PetFinderDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class Raca : IcamposPadrao
    {
        public int RacaId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }


        public Tipo Tipo { get; set; }
        public int UsuarioCriacao { get ; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get ; set; }
    }
}
