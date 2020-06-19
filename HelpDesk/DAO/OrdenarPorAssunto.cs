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
    public class OrdenarPorAssunto : IOrdenar
    {
        private static OrdenarPorAssunto instancia = null;

        private OrdenarPorAssunto()
        {

        }
        public static OrdenarPorAssunto getInstancia()
        {
            if (instancia == null)
            {
                instancia = new OrdenarPorAssunto();
            }
            return instancia;
        }

        public string CommandOrdenar()
        {
            string comando = "ORDER BY T.Assunto ";
            
            return comando;
        }
    }
}
