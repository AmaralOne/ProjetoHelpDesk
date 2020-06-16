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


        public void Atualizar(Pessoa Model)
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

        public bool Remover(Pessoa Model)
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

        public Pessoa Inserir(Pessoa Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Insert into {type} (Nome, CPF, Telefone, Email, Endereco,Tipo,Senha) values (@Nome, @CPF, @Telefone, @Email, @Endereco,@Tipo,@Senha); SET @Id = SCOPE_IDENTITY();";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.GetNome();
                command.Parameters.Add("@CPF", SqlDbType.Text).Value = Model.GetCPF();
                command.Parameters.Add("@Telefone", SqlDbType.Text).Value = Model.GetTelefone();
                command.Parameters.Add("@Email", SqlDbType.Text).Value = Model.GetEmail();
                command.Parameters.Add("@Endereco", SqlDbType.Text).Value = Model.GetEndereco();
                command.Parameters.Add("@Tipo", SqlDbType.Int).Value = type;
                command.Parameters.Add("@Senha", SqlDbType.Int).Value = 0;

                command.Parameters.AddWithValue("@Id", 0).Direction = ParameterDirection.Output;

                if (command.ExecuteNonQuery() > 0)
                {
                    Model.SetId(Convert.ToInt32(command.Parameters["@Id"].Value));
                }

            }

            return Model;
        }

        public IEnumerable<Pessoa> ListarPorParametros(params object[] Keys)
        {

            //Buscar 

            List<Pessoa> colecoes = new List<Pessoa>();

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
                        Pessoa model = new Pessoa();

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }

        public IEnumerable<Pessoa> ListarTudo()
        {
            List<Pessoa> colecoes = new List<Pessoa>();

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
                        Pessoa model = FactoryPessoas.GetPessoas(PessoaTipo.Pessoa);

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());
                        model.SetCPF(row["CPF"].ToString() );
                        model.SetTelefone(row["Telefone"].ToString() );
                        model.SetEmail(row["Email"].ToString() );
                        model.SetEndereco(row["Endereco"].ToString() );

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

        public Usuario LocarizarUsuario(params object[] Keys)
        {
            Usuario model = null;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;

                command.CommandText = $"Select P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe from Pessoa P inner join Equipe E on E.Id = P.CodigoEquipe Where P.Nome=@Nome;";

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Pessoa model;
                        reader.Read();
                        if (reader.GetString(6).Equals("1"))
                        {
                            string senha = reader.GetString(7);
                            int idEquipe = reader.GetInt32(8);
                            string nomeEquipe = reader.GetString(9);
                            model = new Usuario(idEquipe, nomeEquipe, senha);
                        }
                        else
                        {
                            model = new Pessoa();
                        }



                        model.Id = reader.GetInt32(0);
                        model.CPF = reader.GetString(1);
                        model.Nome = reader.GetString(2);
                        model.Email = reader.GetString(3);
                        model.Endereco = reader.GetString(4);
                        model.Telefone = reader.GetString(5);
                    }
                }

            }

            return model;
        }

        public IEnumerable<Usuario> TodosUsuarios()
        {
            List<Usuario> colecoes = new List<Usuario>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;

                command.CommandText = $"Select P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe from Pessoa P inner join Equipe E on E.Id = P.CodigoEquipe;";




                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Pessoa model;
                        if (row["Tipo"].ToString().Equals("1"))
                        {
                            string senha = row["Senha"].ToString();
                            int idEquipe = int.Parse(row["CodigoEquipe"].ToString());
                            string nomeEquipe = row["NomeEquipe"].ToString();
                            model = new Usuario(idEquipe, nomeEquipe, senha);
                        }
                        else
                        {
                            model = new Pessoa();
                        }


                        model.Id = int.Parse(row["Id"].ToString());
                        model.Nome = row["Nome"].ToString();
                        model.Telefone = row["Telefone"].ToString();
                        model.CPF = row["CPF"].ToString();
                        model.Email = row["Email"].ToString();
                        model.Endereco = row["Endereco"].ToString();

                        colecoes.Add((Usuario)model);
                    }
                }

            }

            return colecoes.AsEnumerable();
        }
    }
}
