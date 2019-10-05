using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFinderDomain.Entities
{
    public class Imagem:IcamposPadrao
    {
        public int PetImagemId { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
        public string Nome { get; set; }
        public byte[] Arquivo { get; set; }
        public string Formato { get; set; }
        public bool Capa{ get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int UsuarioCriacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int? UsuarioUltimaAlteracao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
    }
}
