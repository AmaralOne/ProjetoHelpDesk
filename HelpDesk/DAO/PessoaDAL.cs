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
    public class PessoaDAL : GenericDAO<Pessoa>
    {
        private static PessoaDAL instancia = null;
        private PessoaDAL() { }

        public static PessoaDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new PessoaDAL();
            return instancia;
        }



        public override string[] getAtributos()
        {
            return new string[] { "Id", "Nome", "CPF", "Telefone","Email","Endereco","Tipo","Senha","CodigoEquipe" };

        }

        public override string getIndex()
        {
            return "Id";
        }

        public override void getParametros(SqlCommand command, Pessoa model)
        {
            command.Parameters.Add("@Nome", SqlDbType.Text).Value = model.Nome;
            command.Parameters.Add("@CPF", SqlDbType.Text).Value = model.CPF;
            command.Parameters.Add("@Telefone", SqlDbType.Text).Value = model.Telefone;
            command.Parameters.Add("@Email", SqlDbType.Text).Value = model.Email;
            command.Parameters.Add("@Endereco", SqlDbType.Text).Value = model.Endereco;


            if (model.Tipo() == PessoaTipo.Usuario)
            {
                Usuario aux = (Usuario)model;
                command.Parameters.Add("@Tipo", SqlDbType.Text).Value = "1";
                command.Parameters.Add("@Senha", SqlDbType.Text).Value = aux.GetSenha();
                command.Parameters.Add("@CodigoEquipe", SqlDbType.Int).Value = aux.CodigoEquipe;
            }
            else
            {
                command.Parameters.Add("@Tipo", SqlDbType.Text).Value = "0";
                command.Parameters.Add("@Senha", SqlDbType.Text).Value = "0";
                
                command.Parameters.Add("@CodigoEquipe", SqlDbType.Int).Value = DBNull.Value;
            }

        }

        public override void getParametrosIndex(SqlCommand command, Pessoa model)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = model.Id;
        }

        public override string getTabela()
        {
            return "Pessoa";
        }

        public override Pessoa MontarObjeto(DataRow row)
        {
            //P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe
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

            return model;
        }

        public override Pessoa MontarObjeto(SqlDataReader reader)
        {
           // P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe
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



            return model;
        }

        public override Pessoa MontarObjetoVazio()
        {
            return null;
        }

        public override Pessoa receberAutoIncremento(SqlCommand command, Pessoa model)
        {
            command.Parameters.AddWithValue("@Id", 0).Direction = ParameterDirection.Output;

            if (command.ExecuteNonQuery() > 0)
            {
                model.Id = Convert.ToInt32(command.Parameters["@Id"].Value);
            }

            return model;
        }

        public override SqlCommand Select(SqlCommand command)
        {
            command.CommandText = $"Select P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe from Pessoa P left join Equipe E on E.Id = P.CodigoEquipe;";

            return command;

        }

        public override SqlCommand SelectBuscaPorIndex(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"Select P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe from Pessoa P left join Equipe E on E.Id = P.CodigoEquipe Where P.Id=@Id;";

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

            return command;
        }

        public override SqlCommand SelectComParamentro(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"Select P.Id, P.CPF, P.Nome, P.Email, P.Endereco, P.Telefone, P.Tipo, P.Senha, P.CodigoEquipe, E.Nome as NomeEquipe from Pessoa P left join Equipe E on E.Id = P.CodigoEquipe Where P.Nome LIKE ('%'+ @Nome +'%');";
            command.Parameters.Clear();
            command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Keys[0];

            return command;
        }
    }
}
