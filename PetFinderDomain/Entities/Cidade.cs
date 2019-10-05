using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class Cidade:IcamposPadrao
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string CodigoIbge { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public  decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
