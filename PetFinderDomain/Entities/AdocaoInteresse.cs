using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class AdocaoInteresse:IcamposPadrao
    {
        public int AdocaoInteresseId { get; set; }
        public string Aprovado { get; set; }
        public int AdocaoId { get; set; }
        public int InteressadoId { get; set; }
        public virtual Usuario Interessado { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
