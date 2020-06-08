using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Conexao
    {
        private static  Conexao instancia = null;
        private static SqlConnection conexao = null;

        private Conexao() { }

        public static Conexao GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new Conexao();
                conexao = new SqlConnection("Data Source=DESKTOP-1G53BC1\\SQLEXPRESS; Initial Catalog=HelpDesk; Integrated Security=SSPI;");

            }

            return instancia;
        }

        public SqlConnection Abrir()
        {
            if( conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public SqlConnection Buscar()
        {
            return this.Abrir();
        }

        public void Fechar()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public void Disposed()
        {
            this.Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
