using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Arquivo:Acoes
    {
        public string Caminho { get; set; }
        public string Nome { get; set; }
        public string Formato { get; set; }

        public Arquivo(int Id, int CodigoUsuario, string NomeUsuario, DateTime data, string Caminho, string Nome, string Formato)
        {
            this.Id = Id;
            this.CodigoUsuario = CodigoUsuario;
            this.NomeUsuario = NomeUsuario;
            this.Data = data;
            this.Nome = Nome;
            this.Formato = Formato;
            this.Caminho = Caminho;
        }

        public override string Exibir()
        {
            return $"Arquivo:\n{Nome}.{Formato}";
        }

        public override AcoesEnum Tipo()
        {
            return AcoesEnum.Arquivo;
        }
    }
}
