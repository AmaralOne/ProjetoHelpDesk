using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrdernarPorId : IOrdenar
    {
        private static OrdernarPorId instancia = null;

        private OrdernarPorId()
        {

        }
        public static OrdernarPorId getInstancia()
        {
            if (instancia == null)
            {
                instancia = new OrdernarPorId();
            }
            return instancia;
        }
        public string CommandOrdenar()
        {
            string comando = "ORDER BY T.Id ";

            return comando;
        }
    }
}
