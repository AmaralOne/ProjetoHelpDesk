
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System;


public class PessoaDAO : IDAO<Equipe>, IDisposable
    {
        private static PessoaDAO instancia = null;

        private string Tabela = "Equipe";
        private string Colunas = "Id, Nome ";

        // FLAVIO boiola
        private PessoaDAO() { }

        public static PessoaDAO GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new PessoaDAO();
            }

            return instancia;
        }


        public void Atualizar(Equipe Model)
        {
            using(SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Update {Tabela} set  Nome=@Nome Where Id=@Id";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.Nome;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Model.Id;

                command.ExecuteNonQuery();

            }
        }

        public bool Remover( Equipe Model)
        {

            bool retornar = false;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Delete from {Tabela} Where Id=@Id";

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

        public Equipe Inserir(Pessoa Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Insert into {Tabela} (Nome, Ativo) values (@Nome,'1'); SET @Id = SCOPE_IDENTITY();";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.Nome;

                command.Parameters.AddWithValue("@Id", 0).Direction = ParameterDirection.Output;

                if (command.ExecuteNonQuery() > 0)
                {
                    Model.Id = Convert.ToInt32(command.Parameters["@Id"].Value);
                }

            }

            return Model;
        }

        public IEnumerator<Equipe> ListarPorParametros(params object[] Keys)
        {
            List<Equipe> colecoes = new List<Equipe>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {Tabela} Where Nome LIKE ('%'+ @Nome +'%') and Ativo != '0';";
                command.Parameters.Clear();
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Equipe model = new Equipe();

                        model.Id = int.Parse(row["Id"].ToString());
                        model.Nome = row["Nome"].ToString();

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.GetEnumerator();
        }

        public IEnumerator<Equipe> ListarTudo()
        {
            List<Equipe> colecoes = new List<Equipe>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {Tabela} Where Ativo != '0';";

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    
                    foreach(DataRow row in tabela.Rows)
                    {
                        Equipe model = new Equipe();

                        model.Id = int.Parse(row["Id"].ToString());
                        model.Nome = row["Nome"].ToString();

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.GetEnumerator();
        }

        public Equipe LocarizarPorCodigo(params object[] Keys)
        {
            Equipe model = null;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {Tabela} Where Id=@Id and Ativo != '0';";

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        model = new Equipe();
                        reader.Read();

                        model.Id = reader.GetInt32(0);
                        model.Nome = reader.GetString(1);
                    }
                }

            }

            return model;
        }
    }