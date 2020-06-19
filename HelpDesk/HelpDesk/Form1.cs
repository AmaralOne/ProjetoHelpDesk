using DAO;
using Model;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class Form1 : Form, Observador
    {
        private static Form1 instacia = null;
        private Login login = null;
        
        private Form1(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        public static Form1 GetInstancia(Login login)
        {
            if(instacia == null)
            {
                instacia = new Form1(login);

            }


            return instacia;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            

        }

        private void btn_Cadastro_Status_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cadastro_Urgencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cadastro_Servico_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_NovoTicket_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_Inicio.Value = DateTime.Today.AddMonths(-1);
            dt_Final.Value = DateTime.Today.AddDays(1).AddMinutes(-1);

        }

        void CarregarGrid()
        {
            List<Ticket> tickets = null;
            try
            {
                dataGridTicket.AutoGenerateColumns = false;
                TicketDAL ticketDAL = TicketDAL.GetInstancia();
                ticketDAL.OrdenarPor(OrdenarTicketType.Id);
                tickets = ticketDAL.ListarPorParametros(txt_Pesquisar.Text, dt_Inicio.Value, dt_Final.Value).ToList();
                dataGridTicket.DataSource = null;
                dataGridTicket.DataSource = tickets;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro!!!\nNão foi possivel buscar os Tickets no Banco de Dados. " + ex.Message, $"Lista de Chamados");

            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Equipe).Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Status).Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Urgencia).Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Servico).Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //PessoaDAL.GetInstancia().Inserir(new Model.Pessoa(1, "Flávio Filho", "2", "22", "sfs2@", "sfs"));
            //PessoaDAL.GetInstancia().Atualizar(new Model.Pessoa(1, "Flávio Filho", "2", "22", "sfs2@", "sfs"));
            //PessoaDAL.GetInstancia().Remover(new Model.Pessoa(2, "Flávio Filho", "2", "22", "sfs2@", "sfs"));
            //PessoaDAL.GetInstancia().ListarPorParametros("Flávio Filho");
            //IEnumerable<Pessoa> d = PessoaDAL.GetInstancia().ListarTudo();
            //Pessoa p = PessoaDAL.GetInstancia().LocarizarPorCodigo(1);
            CadastroPessoas.GetInstancia().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Ticket model = new Ticket();
            bool erro = false;
            try
            {
                model.Id = (int.Parse(dataGridTicket.CurrentRow.Cells[0].Value.ToString()));

                model = TicketDAL.GetInstancia().LocarizarPorCodigo(model.Id);
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro!!!\nSelecione um Ticket para poder Deletar", $"Lista de Chamados");
                erro = true;
            }

            if (erro == false)
            {
                try
                {
                    TicketDAL.GetInstancia().Remover(model);
                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar Deletar Ticket!!!\n" + ex.Message, $"Lista de Chamados");

                }
            }
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
            CadastroTicket c = CadastroTicket.GetInstancia();
            c.incluir(this);
            c.Show();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Ticket ticket = new Ticket();
            //ticket.NomePessoa = "Flávio";
            //ticket.Assunto = "teste";
            //ticket.CodigoPessoa = 1;
            //ticket.CodigoStatus = 1;
            //ticket.CodigoServico = 1;
            //ticket.CodigoUrgencia = 1;
            //ticket.CodigoResponsavel = 2;
            //ticket.NomeResponsavel = "Matheus";
            //ticket.PrevisaoTermico = DateTime.Now;
            //List<Mensagem> aux = new List<Mensagem>();
            //aux.Add(new Mensagem(1, 1, "Flávio", DateTime.Now, "Teste"));
            //ticket.ListaAcoes = aux.AsEnumerable();
            //ticket.ListaAcoes.Count();

            try
            {
                string id = dataGridTicket.CurrentRow.Cells[0].Value.ToString();
                Ticket t = TicketDAL.GetInstancia().LocarizarPorCodigo(int.Parse(id));
                CadastroTicket c = CadastroTicket.GetInstancia(t);
                c.incluir(this);
                c.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro!!!\nNão foi possivel abrir este Ticket. " + ex.Message, $"Lista de Chamados");

            }

        }

        private void dt_Inicio_ValueChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txt_Pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarGrid();
        }

        public void atualizar()
        {
            CarregarGrid();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

            try
            {
                string id = dataGridTicket.CurrentRow.Cells[0].Value.ToString();
                Ticket t = TicketDAL.GetInstancia().LocarizarPorCodigo(int.Parse(id));
                Util.EscreverPDF($"Ticket{t.Id}.pdf", t.Imprimir());
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro!!!\nNão foi possivel imprimir este Ticket. " + ex.Message, $"Lista de Chamados");

            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
/*            TicketDAL ticketDAL = TicketDAL.GetInstancia();
            ticketDAL.OrdenarPor(OrdenarTicketType.Id);
            ColecaoDeTickets colecao = ticketDAL.listagemTicketsOrdenados();
            dataGridTicket.DataSource = null;
            dataGridTicket.DataSource = colecao;*/
        }
    }
}
