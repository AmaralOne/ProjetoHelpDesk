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
        public int Endereco { get; set; }

        public bool ValidaEmail(String email)
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

        public bool ValidaTelefone(String telefone)
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
