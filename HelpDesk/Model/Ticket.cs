using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket:Item
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
        public string NomeServico { get; set; }

        public int CodigoEquipe { get; set; }
        public string NomeEquipe { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime PrevisaoTermico { get; set; }
        public DateTime DataAlteracao { get; set; }

        public IEnumerable<Acoes> ListaAcoes;

        public Ticket()
        {
            ListaAcoes = new List<Acoes>().AsEnumerable();
            
        }

        public string Imprimir()
        {
            string retorno = $"Ticket: {this.Id}\n" +
                $"Assunto: {this.Assunto}\n" +
                $"Pessoa: {this.NomePessoa}\n" +
                $"Responsável: {this.NomeResponsavel}\n" +
                $"Status: {this.NomeStatus}\n" +
                $"Serviço: {this.NomeServico}\n" +
                $"Urgência: {this.NomeUrgencia}\n" +
                $"Data de Criação: {this.DataInicio.ToString()}\n" +
                $"Ultima Alteração: {this.DataAlteracao.ToString()}\n" +
                $"Previsão de Solução:{this.PrevisaoTermico.ToString()}\n\n" +
                $"Ações:\n";
            foreach(var elemento in ListaAcoes)
            {
                retorno = retorno + elemento.Imprimir();
            }

            return retorno;

        }
    }
}
