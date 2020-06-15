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
    public abstract class GenericDAO<T> : IDisposable
    {
        public GenericDAO() {  }

        public abstract string getTabela();
        public abstract string [] getAtributos();
        public abstract string getIndex();

        public abstract bool AutoIncrement();
        public abstract void getParametros(SqlCommand command, T model);

        public abstract void getParametrosIndex(SqlCommand command, T model);

        public abstract T receberAutoIncremento(SqlCommand command, T model);

        public abstract SqlCommand SelectComParamentro(SqlCommand command, params object[] Keys);

        public abstract SqlCommand Select(SqlCommand command);

        public abstract SqlCommand SelectBuscaPorIndex(SqlCommand command,params object[] Keys);


        public abstract T MontarObjeto(DataRow row);

        public abstract T MontarObjetoVazio();

        public abstract T MontarObjeto(SqlDataReader reader);

        private string montarValues()
        {
            string aux = "";
            foreach(string at in getAtributos())
            {


                if (AutoIncrement())
                {
                    if (!getIndex().Equals(at))
                    {
                        aux = aux + at + "=@" + at + ", ";
                    }
                }
                else
                {
                    aux = aux + at + "=@" + at + ", ";
                }

            }
            aux = aux.Substring(0, aux.Length - 2);

            return aux;
        }

        public string montarAtributos()
        {
            string aux = "";
            foreach (string at in getAtributos())
            {
                if (AutoIncrement())
                {
                    if (!getIndex().Equals(at))
                    {
                        aux = aux + at + ", ";
                    }
                }
                else
                {
                    aux = aux + at + ", ";
                }
                
                    
            }
            aux = aux.Substring(0, aux.Length - 2);

            return aux;
        }

        public string montarParametros()
        {
            string aux = "";
            foreach (string at in getAtributos())
            {


                if (AutoIncrement())
                {
                    if (!getIndex().Equals(at))
                    {
                        aux = aux + "@" + at + ", ";
                    }
                }
                else
                {
                    aux = aux + "@" + at + ", ";
                }

            }
            aux = aux.Substring(0, aux.Length - 2);
            return aux;
        }


        public virtual void Atualizar(T Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Update {getTabela()} set  {montarValues()} Where {getIndex()}=@{getIndex()}";

                getParametros(command, Model);
                getParametrosIndex(command, Model);

                command.ExecuteNonQuery();

            }
        }

        public virtual bool Remover(T Model)
        {

            bool retornar = false;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Delete from {getTabela()} Where {getIndex()}=@{getIndex()}";

                getParametrosIndex(command, Model);

                if (command.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }

            }

            return retornar;


        }

        public virtual T Inserir(T Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Insert into {getTabela()} ({montarAtributos()}) values ({montarParametros()}); SET @{getIndex()} = SCOPE_IDENTITY();";

                getParametros(command, Model);

                Model = receberAutoIncremento(command, Model);

            }

            return Model;
        }

        public virtual IEnumerable<T> ListarPorParametros(params object[] Keys)
        {
            List<T> colecoes = new List<T>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SelectComParamentro(command, Keys);


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        T model = MontarObjeto(row);

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }


        public virtual IEnumerable<T> ListarTudo()
        {
            List<T> colecoes = new List<T>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                Select(command);


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        T model = MontarObjeto(row);

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }

        public virtual T LocarizarPorCodigo(params object[] Keys)
        {
            T model = MontarObjetoVazio();
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SelectBuscaPorIndex(command, Keys);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        model = MontarObjeto(reader);
                    }
                }

            }

            return model;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
