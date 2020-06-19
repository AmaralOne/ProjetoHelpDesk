using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdapterCriptografia : Cript
    {
        public string Criptografa(string senha)
        {
           return Util.CalculateSHA1(senha);
        }
    }
}
