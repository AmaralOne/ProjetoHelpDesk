using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Acoes:Item
    {
        // flavio 
        public int Id { get; set; }

        public int IdTicket { get; set; }
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime Data { get; set; }

        public abstract string Exibir();

        public string Imprimir()
        {
            string retorno = $"\n**************************************************\n" +
                $"{this.Id}   {this.Data}   {NomeUsuario}  \n";
            return retorno + Exibir();
        }

        public abstract AcoesEnum Tipo();

    }
}
