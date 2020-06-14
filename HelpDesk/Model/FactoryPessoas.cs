using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FactoryPessoas
    {
        public static FactoryPessoas GetPessoas(PessoaTipo type)
        {
            switch (type)
            {
                case PessoaTipo.Pessoa: return new Pessoa();
                case PessoaTipo.Usuario: return new Usuario();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
