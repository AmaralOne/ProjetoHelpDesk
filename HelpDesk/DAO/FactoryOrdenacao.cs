using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FactoryOrdenacao
    {
        public static IOrdenar getOrdenacao(OrdenarTicketType type)
        {
            switch(type)
            {
                case OrdenarTicketType.Id: return OrdernarPorId.getInstancia();
                case OrdenarTicketType.Assunto: return OrdenarPorAssunto.getInstancia();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
