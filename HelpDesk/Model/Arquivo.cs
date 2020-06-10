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
    }
}
