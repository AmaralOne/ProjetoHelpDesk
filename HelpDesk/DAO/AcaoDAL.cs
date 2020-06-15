using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    class AcaoDAL : GenericDAO<Acoes>
    {

        private static AcaoDAL instancia = null;
        private AcaoDAL() { }

        public static AcaoDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new AcaoDAL();
            return instancia;
        }

        public override string[] getAtributos()
        {
            return new string[] { "Id", "IdTicket", "CodigoUsuario", "Data", "Texto", "Caminho", "Nome", "Formato", "Tipo" };

        }

        public override string getIndex()
        {
            return "IdTicket";
        }

        public override void getParametros(SqlCommand command, Acoes model)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = model.Id;
            command.Parameters.Add("@IdTicket", SqlDbType.Int).Value = model.IdTicket;
            command.Parameters.Add("@CodigoUsuario", SqlDbType.Int).Value = model.CodigoUsuario;
            command.Parameters.Add("@Data", SqlDbType.DateTime).Value = model.Data;

            if(model.Tipo() == AcoesEnum.Mensagem)
            {
                Mensagem aux = (Mensagem)model;
                command.Parameters.Add("@Texto", SqlDbType.Text).Value = aux.Texto;
                command.Parameters.Add("@Caminho", SqlDbType.Text).Value = "";
                command.Parameters.Add("@Nome", SqlDbType.Text).Value = "";
                command.Parameters.Add("@Formato", SqlDbType.Text).Value = "";
                command.Parameters.Add("@Tipo", SqlDbType.Text).Value = "1";

            }
            else
            {
                Arquivo aux = (Arquivo)model;
                command.Parameters.Add("@Texto", SqlDbType.Text).Value = "";
                command.Parameters.Add("@Caminho", SqlDbType.Text).Value = aux.Caminho;
                command.Parameters.Add("@Nome", SqlDbType.Text).Value = aux.Nome;
                command.Parameters.Add("@Formato", SqlDbType.Text).Value = aux.Formato;
                command.Parameters.Add("@Tipo", SqlDbType.Text).Value = "2";

            }

        }

        public override void getParametrosIndex(SqlCommand command, Acoes model)
        {
            string nada = "";
        }

        public override string getTabela()
        {
            return "Acoes";
        }

        private string SqlSelect()
        {
            return "Select A.Id," +
                " A.IdTicket," +
                " A.CodigoUsuario," +
                " U.Nome as 'Usuario'," +
                " A.Data, A.Texto," +
                " A.Caminho," +
                " A.Nome," +
                " A.Formato," +
                " A.Tipo from Acoes A inner join Pessoa U on U.Id = A.CodigoUsuario";
        }

        public override Acoes MontarObjeto(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            int idTicket = int.Parse(row["IdTicket"].ToString());
            int codigoUsuario = int.Parse(row["CodigoUsuario"].ToString());
            string nomeUsuario = row["Usuario"].ToString();
            DateTime data = DateTime.Parse(row["Data"].ToString());
            string texto = row["Texto"].ToString();
            string caminho = row["Caminho"].ToString();
            string Nome = row["Nome"].ToString();
            string Formato = row["Formato"].ToString();

            Acoes model;
            if (row["Tipo"].ToString().Equals("1"))
            {

                model = new Mensagem(id,idTicket,codigoUsuario,nomeUsuario,data,texto);
            }
            else
            {
                model = new Arquivo(id,idTicket,codigoUsuario,nomeUsuario,data,caminho,Nome,Formato);
            }

            return model;
        }

        public override Acoes MontarObjeto(SqlDataReader reader)
        {
            reader.Read();
            int id = reader.GetInt32(0); 
            int idTicket = reader.GetInt32(1);
            int codigoUsuario = reader.GetInt32(2);
            string nomeUsuario = reader.GetString(3);
            DateTime data = reader.GetDateTime(4);
            string texto = reader.GetString(5);
            string caminho = reader.GetString(6);
            string Nome = reader.GetString(7);
            string Formato = reader.GetString(8);

            Acoes model;
            if (reader.GetString(9).Equals("1"))
            {

                model = new Mensagem(id, idTicket, codigoUsuario, nomeUsuario, data, texto);
            }
            else
            {
                model = new Arquivo(id, idTicket, codigoUsuario, nomeUsuario, data, caminho, Nome, Formato);
            }

            return model;
        }

        public override Acoes MontarObjetoVazio()
        {
            return null;
        }

        public override Acoes receberAutoIncremento(SqlCommand command, Acoes model)
        {

            command.ExecuteNonQuery();
            

            return model;
        }

        public override SqlCommand Select(SqlCommand command)
        {
            command.CommandText = SqlSelect();

            return command;
        }

        public override SqlCommand SelectBuscaPorIndex(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"{SqlSelect()} Where A.IdTicket=@Id;";

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

            return command;
        }

        public override SqlCommand SelectComParamentro(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"{SqlSelect()} Where A.IdTicket=@IdTicket;";
            command.Parameters.Clear();
            command.Parameters.Add("@IdTicket", SqlDbType.Int).Value = Keys[0];

            return command;
        }

        public override bool AutoIncrement()
        {
            return false;
        }
    }
}
