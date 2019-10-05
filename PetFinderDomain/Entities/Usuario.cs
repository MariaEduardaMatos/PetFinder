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
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
