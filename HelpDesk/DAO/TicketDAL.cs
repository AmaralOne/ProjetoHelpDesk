using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TicketDAL : GenericDAO<Ticket>
    {
        private static TicketDAL instancia = null;
        protected IOrdenar ordenar = null;
        private OrdenarTicketType type = OrdenarTicketType.Id;
        private TicketDAL() { }

        public static TicketDAL GetInstancia()
        {
            if (instancia == null)
                instancia = new TicketDAL();
            return instancia;
        }

        public void OrdenarPor(OrdenarTicketType type)
        {
            this.type = type;
            ordenar = FactoryOrdenacao.getOrdenacao(type);
        }

        public OrdenarTicketType OrdenarPor()
        {
            return this.type;
        }

       /* public ColecaoDeTickets listagemTicketsOrdenados()
        {
            ColecaoDeTickets resultado = new ColecaoDeTickets();

            List<Ticket> listaDeTickets = new List<Ticket>();

            SqlCommand command = ordenar.CommandOrdenar();


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach(DataRow row in tabela.Rows)
                {
                    Ticket model = MontarObjeto(row);

                    listaDeTickets.Add(model);
                }
                resultado.Add(listaDeTickets);
                }
            return resultado;
            }*/

        public override string[] getAtributos()
        {
            return new string[] { "Id", "Assunto", "DataInicio", "DataPrevisaoFinal", "DataAlteracao", "CodigoPessoa", "CodigoUsuario", "CodigoServico", "CodigoUrgencia", "CodigoStatus" };

        }

        public override string getIndex()
        {
            return "Id";
        }

        public override void getParametros(SqlCommand command, Ticket model)
        {
            command.Parameters.Add("@Assunto", SqlDbType.Text).Value = model.Assunto;
            command.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = model.DataInicio;
            command.Parameters.Add("@DataPrevisaoFinal", SqlDbType.DateTime).Value = model.PrevisaoTermico;
            command.Parameters.Add("@DataAlteracao", SqlDbType.DateTime).Value = model.DataAlteracao;
            command.Parameters.Add("@CodigoPessoa", SqlDbType.Int).Value = model.CodigoPessoa;
            command.Parameters.Add("@CodigoUsuario", SqlDbType.Int).Value = model.CodigoResponsavel;
            command.Parameters.Add("@CodigoServico", SqlDbType.Int).Value = model.CodigoServico;
            command.Parameters.Add("@CodigoUrgencia", SqlDbType.Int).Value = model.CodigoUrgencia;
            command.Parameters.Add("@CodigoStatus", SqlDbType.Int).Value = model.CodigoStatus;
        }

        public override void getParametrosIndex(SqlCommand command, Ticket model)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = model.Id;
        }

        public override string getTabela()
        {
            return "Ticket";
        }

        private string SqlSelect()
        {
            return "select T.Id, T.Assunto, T.DataInicio, T.DataAlteracao, T.DataPrevisaoFinal, " +
                    "T.CodigoPessoa, P.Nome as 'Pessoa', " +
                    "T.CodigoUsuario, U.Nome as 'Usuario', " +
                    "T.CodigoServico, S.Nome as 'Servico', " +
                    "T.CodigoUrgencia, Ur.Nome as 'Urgencia', " +
                    "T.CodigoStatus, St.Nome as 'Status' " +
                    "from Ticket T " +
                    "inner join Pessoa P on P.Id = T.CodigoPessoa " +
                    "inner join Pessoa U on U.Id = T.CodigoUsuario " +
                    "inner join Servico S on S.Id = T.CodigoServico " +
                    "inner join Urgencia Ur on Ur.Id = T.CodigoUrgencia " +
                    "inner join Status St on St.Id = T.CodigoStatus ";
        }

        public override Ticket MontarObjeto(DataRow row)
        {
            Ticket model = new Ticket();

            

            model.Id = int.Parse(row["Id"].ToString());
            model.Assunto = row["Assunto"].ToString();
            model.DataInicio = DateTime.Parse(row["DataInicio"].ToString());
            model.DataAlteracao = DateTime.Parse(row["DataAlteracao"].ToString());
            model.PrevisaoTermico = DateTime.Parse(row["DataPrevisaoFinal"].ToString());

            model.CodigoPessoa = int.Parse(row["CodigoPessoa"].ToString());
            model.NomePessoa = row["Pessoa"].ToString();

            model.CodigoResponsavel = int.Parse(row["CodigoUsuario"].ToString());
            model.NomeResponsavel = row["Usuario"].ToString();

            model.CodigoServico = int.Parse(row["CodigoServico"].ToString());
            model.NomeServico = row["Servico"].ToString();

            model.CodigoUrgencia = int.Parse(row["CodigoUrgencia"].ToString());
            model.NomeUrgencia = row["Urgencia"].ToString();

            model.CodigoStatus = int.Parse(row["CodigoStatus"].ToString());
            model.NomeStatus = row["Status"].ToString();


            return model;
        }

        public override Ticket MontarObjeto(SqlDataReader reader)
        {
            Ticket model = new Ticket();
            reader.Read();

            model.Id = reader.GetInt32(0);


            model.Assunto = reader.GetString(1);
            model.DataInicio = reader.GetDateTime(2);
            model.DataAlteracao = reader.GetDateTime(3);
            model.PrevisaoTermico = reader.GetDateTime(4);

            model.CodigoPessoa = reader.GetInt32(5);
            model.NomePessoa = reader.GetString(6);

            model.CodigoResponsavel = reader.GetInt32(7);
            model.NomeResponsavel = reader.GetString(8);

            model.CodigoServico = reader.GetInt32(9);
            model.NomeServico = reader.GetString(10);

            model.CodigoUrgencia = reader.GetInt32(11);
            model.NomeUrgencia = reader.GetString(12);

            model.CodigoStatus = reader.GetInt32(13);
            model.NomeStatus = reader.GetString(14);



            return model;
        }

        public override Ticket MontarObjetoVazio()
        {
            return null;
        }

        public override Ticket receberAutoIncremento(SqlCommand command, Ticket model)
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
            command.CommandText = SqlSelect();

            return command;
        }

        public override SqlCommand SelectBuscaPorIndex(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"{SqlSelect()} Where T.Id=@Id;";

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Keys[0];

            return command;
        }

        public override SqlCommand SelectComParamentro(SqlCommand command, params object[] Keys)
        {
            command.CommandText = $"{SqlSelect()} Where T.Assunto LIKE ('%'+ @Assunto +'%') and T.DataInicio >= @DataInicio and T.DataInicio <= @DataFinal {ordenar.CommandOrdenar()}";
            command.Parameters.Clear();
            command.Parameters.Add("@Assunto", SqlDbType.VarChar).Value = Keys[0];
            command.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = Keys[1];
            command.Parameters.Add("@DataFinal", SqlDbType.DateTime).Value = Keys[2];

            return command;
        }

        public override Ticket LocarizarPorCodigo(params object[] Keys)
        {
            Ticket aux = base.LocarizarPorCodigo(Keys);
            IEnumerable<Acoes> acoes = AcaoDAL.GetInstancia().ListarPorParametros(aux.Id);
            aux.ListaAcoes = acoes;

            return aux;
        }

        public override Ticket Inserir(Ticket Model)
        {
            Ticket aux = base.Inserir(Model);

            foreach(Acoes a in aux.ListaAcoes)
            {
                a.IdTicket = aux.Id;
                AcaoDAL.GetInstancia().Inserir(a);
            }

            return aux;
        }

        public override void Atualizar(Ticket Model)
        {
            base.Atualizar(Model);
            AcaoDAL.GetInstancia().Remover(Model.ListaAcoes.First());
            foreach (Acoes a in Model.ListaAcoes)
            {

                AcaoDAL.GetInstancia().Inserir(a);
            }

        }

        public override bool Remover(Ticket Model)
        {
            if (AcaoDAL.GetInstancia().Remover(Model.ListaAcoes.First()))
            {
                if (base.Remover(Model))
                {
                
                    return true;
                }
            }
            return false;
        }

        public override bool AutoIncrement()
        {
            return true;
        }
    }
}
