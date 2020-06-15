using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mensagem:Acoes
    {
        public string Texto { get; set; }

        public Mensagem(int Id, int IdTicket, int CodigoUsuario, string NomeUsuario, DateTime data, string Texto)
        {
            this.Id = Id;
            this.IdTicket = IdTicket;
            this.CodigoUsuario = CodigoUsuario;
            this.NomeUsuario = NomeUsuario;
            this.Data = data;
            this.Texto = Texto;
        }

        public override string Exibir()
        {
            return $"Mensagem:\n{Texto}";
        }

        public override AcoesEnum Tipo()
        {
            return AcoesEnum.Mensagem;
        }
    }
}
