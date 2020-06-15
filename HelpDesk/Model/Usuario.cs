using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario : Pessoa
    {
        public Usuario() : base()
        {

        }

        public Usuario(int idUsuario, string NomeUsuario,int codigoEquipe, string nomeEquipe, string senha) : base()
        {
            this.Id = idUsuario;
            this.Nome = NomeUsuario;
            this.CodigoEquipe = codigoEquipe;
            this.NomeEquipe = nomeEquipe;
            this.Senha = (senha);
        }
        public Usuario(int codigoEquipe, string nomeEquipe, string senha): base()
        {
            CodigoEquipe = codigoEquipe;
            NomeEquipe = nomeEquipe;
            Senha = (senha);
        }

        public int CodigoEquipe { get; set; }
        public string NomeEquipe { get; set; }
        private string Senha { get; set; }

        public override PessoaTipo Tipo() { return PessoaTipo.Usuario; }

        public string GetSenha()
        {
            return Senha;
        }

        public bool Autentificacao(string Nome, string Senha)
        {
            if (this.Nome == Nome && this.Senha == Util.CalculateSHA1(Senha))
                return true;
            return false;
        }

        public bool AlterarSenha(string Nome, string SenhaAtual, string NovaSenha)
        {
            if (this.Autentificacao(Nome, SenhaAtual))
            {
                this.Senha = Util.CalculateSHA1(NovaSenha);
                return true;
            }
                
            return false;
        }
    }
}
