using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ExtendDAL<T>
    {
        string getTabla();
        string getAtributos();

        void getParametros(SqlCommand command,T model);
    }
}
