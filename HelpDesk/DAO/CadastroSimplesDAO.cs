﻿using DAO.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CadastroSimplesDAO
    {
        private static CadastroSimplesDAO instancia = null;

        private string Tabela = "Equipe";
        private string Colunas = "Id, Nome ";

        private static CadastrosType type = 0;


        private CadastroSimplesDAO() { }

        public static CadastroSimplesDAO GetInstancia(CadastrosType typeCadastro)
        {
            if (instancia == null)
            {
                instancia = new CadastroSimplesDAO();
            }

            type = typeCadastro;
            

            return instancia;
        }


        public void Atualizar(ICadastro Model)
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

        public void Inativar(ICadastro Model)
        {

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Update {type} set  Ativo='0' Where Id=@Id";

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Model.GetId();

                command.ExecuteNonQuery();

            }


        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ICadastro Inserir(ICadastro Model)
        {
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Insert into {type} (Nome, Ativo) values (@Nome,'1'); SET @Id = SCOPE_IDENTITY();";

                command.Parameters.Add("@Nome", SqlDbType.Text).Value = Model.GetNome();

                command.Parameters.AddWithValue("@Id", 0).Direction = ParameterDirection.Output;

                if (command.ExecuteNonQuery() > 0)
                {
                    Model.SetId(Convert.ToInt32(command.Parameters["@Id"].Value));
                }

            }

            return Model;
        }

        public IEnumerator<ICadastro> ListarPorParametros(params object[] Keys)
        {
            List<ICadastro> colecoes = new List<ICadastro>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Nome LIKE ('%'+ @Nome +'%') and Ativo != '0';";
                command.Parameters.Clear();
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        ICadastro model = FactoryCadastros.GetCadastro(type);

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.GetEnumerator();
        }

        public IEnumerator<ICadastro> ListarTudo()
        {
            List<ICadastro> colecoes = new List<ICadastro>();

            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Ativo != '0';";

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        ICadastro model = FactoryCadastros.GetCadastro(type);

                        model.SetId(int.Parse(row["Id"].ToString()));
                        model.SetNome(row["Nome"].ToString());

                        colecoes.Add(model);
                    }
                }

            }

            return colecoes.GetEnumerator();
        }

        public ICadastro LocarizarPorCodigo(params object[] Keys)
        {
            ICadastro model = null;
            using (SqlCommand command = Conexao.GetInstancia().Buscar().CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = $"Select {Colunas} from {type} Where Id=@Id and Ativo != '0';";

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        model = FactoryCadastros.GetCadastro(type);
                        reader.Read();

                        model.SetId( reader.GetInt32(0));
                        model.SetNome(reader.GetString(1));
                    }
                }

            }

            return model;
        }
    }
}
