using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class Usuario:IcamposPadrao
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public DateTime DataNasci { get; set; }

        public int Endereco { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
