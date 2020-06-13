using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Assunto { get; set; }
        public int CodigoPessoa { get; set; }
        public string NomePessoa { get; set; }
    }
}
