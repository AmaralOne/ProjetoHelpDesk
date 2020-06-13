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
     public class PessoaDAO
    {
        private static PessoaDAO instancia = null;

        private string Tabela = "Pess";
        private string Colunas = "Id, Nome ";

        private static PessoaTipo type;


        private PessoaDAO() { }

        public static PessoaDAO GetInstancia(PessoaTipo typePessoa)
        {
            if (instancia == null)
            {
                instancia = new PessoaDAO();
            }

            type = typePessoa;
            

            return instancia;
        }


        public void Atualizar(IPessoa Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Update {type} set  Nome=@Nome Where Id=@Id";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.GetNome();
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Model.GetId();

                command.ExecuteNonQuery();

            }
        }

        public bool Remover(IPessoa Model)
        {
            bool retornar = false;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Delete from {type} Where Id=@Id";

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Model.GetId();

                if (command.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }

            }

            return retornar;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IPessoa Inserir(IPessoa Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Insert into {type} (Nome) values (@Nome); SET @Id = SCOPE_IDENTITY();";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.GetNome();

                command.Parameters.AddWithValue("@Id", 0).Direction = ParameterDirection.Output;

                if (command.ExecuteNonQuery() > 0)
                {
                    Model.SetId(Convert.ToInt32(command.Parameters["@Id"].Value));
                }

            }

            return Model;
        }

        public IEnumerable<IPessoa> ListarPorParametros(params object[] Keys)
        {
            List<IPessoa> colecoes = new List<IPessoa>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Nome LIKE ('%'+ @Nome +'%');";
                command.Parameters.Clear();
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        IPessoa model = new Pessoa();

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }

        public IEnumerable<ICadastro> ListarTudo()
        {
            List<ICadastro> colecoes = new List<ICadastro>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type};";

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        ICadastro model = FactoryCadastros.GetCadastro(CadastrosType.Equipe);

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }

        public ICadastro LocarizarPorCodigo(params object[] Keys)
        {
            ICadastro model = null;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Id=@Id;";

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        model = FactoryCadastros.GetCadastro(CadastrosType.Equipe);
                        reader.Read();

                        model.SetId( reader.GetInt32(0));
                        model.SetNome(reader.GetString(1));
                    }
                }

            }

            return model;
        }

        public ICadastro LocarizarPorNome(params object[] Keys)
        {
            ICadastro model = null;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Nome=@Nome;";

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        model = FactoryCadastros.GetCadastro(CadastrosType.Equipe);
                        reader.Read();

                        model.SetId(reader.GetInt32(0));
                        model.SetNome(reader.GetString(1));
                    }
                }

            }

            return model;
        }
    }
}
