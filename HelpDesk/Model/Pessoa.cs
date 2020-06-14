using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Pessoa() { }
        public Pessoa(string Nome, string CPF, string Telefone, string Email, String Endereco)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Endereco = Endereco;
        }

        public virtual PessoaTipo Tipo() { return PessoaTipo.Pessoa; }

        public int GetId() { return this.Id;  }

        public void SetId(int ID)
        {
            this.Id = ID;
        }

        public string GetNome() { return this.Nome; }

        public void SetNome(string NOME)
        {
            this.Nome = NOME;
        }

        public string GetCPF() { return this.CPF; }

        public void SetCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string GetTelefone() { return this.Telefone; }

        public void SetTelefone(string TELEFONE)
        {
            this.Telefone = TELEFONE;
        }

        public string GetEmail() { return this.Email; }

        public void SetEmail(string EMAIL)
        {
            this.Email = EMAIL;
        }

         public string GetEndereco() { return this.Endereco; }

        public void SetEndereco(string ENDERECO)
        {
            this.Endereco = ENDERECO;
        }


        public static bool ValidaEmail(String email)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaTelefone(String telefone)
        {
            string strModelo = "^\\([1 - 9]{ 2}\\) (?:[2 - 8] | 9[1 - 9])[0 - 9]{ 3}\\-[0 - 9]{ 4}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(telefone, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
