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

        public int CodigoResponsavel { get; set; }
        public string NomeResponsavel { get; set; }

        public int CodigoStatus { get; set; }
        public string NomeStatus { get; set; }

        public int CodigoUrgencia { get; set; }
        public string NomeUrgencia { get; set; }

        public int CodigoServico { get; set; }
        public int NomeServico { get; set; }

        public int CodigoEquipe { get; set; }
        public int NomeEquipe { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime PrevisaoTermico { get; set; }
        public DateTime DataAlteracao { get; set; }

        public IEnumerable<Acoes> ListaAcoes;

        public Ticket()
        {
            ListaAcoes = new List<Acoes>().AsEnumerable();
            
        }



    }
}
