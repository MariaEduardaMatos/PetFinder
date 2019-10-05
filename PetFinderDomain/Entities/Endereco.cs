using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class Endereco:IcamposPadrao

    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Referecia { get; set; }
        public string CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public string EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public string PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public string Cep { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
