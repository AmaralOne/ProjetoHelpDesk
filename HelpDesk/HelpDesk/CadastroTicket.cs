using DAO;
using Model;
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
    public partial class CadastroTicket : Form
    {
        private static CadastroTicket instancia = null;
        private Boolean novo = true;
        private Boolean erro = false;
        private CadastroSimplesDAO cadastoSimplesDao = null;
        private List<Acoes> itens_acoes = new List<Acoes>();



        private CadastroTicket()
        {
            InitializeComponent();
        }


        public static CadastroTicket GetInstancia()
        {

            if (instancia == null)
            {
                instancia = new CadastroTicket();
            }


            return instancia;
        }

        private void CadastroTicket_Load(object sender, EventArgs e)
        {

            PreencherListadePessoas();
            PreencherListadeUsuarios();
            PreencherCombobox(CadastrosType.Status);
            PreencherCombobox(CadastrosType.Urgencia);
            PreencherCombobox(CadastrosType.Servico);
        }

        private void PreencherListadePessoas()
        {
            try
            {


                List<Pessoa> pessoas = new List<Pessoa>();
                pessoas.Add(new Pessoa(1, "Flávio","222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(2, "Joao", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(3, "Victor", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(4, "Maria", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(5, "Luis", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(6, "Karol", "222", "9999", "f@f.com", "e"));
                IEnumerator<Pessoa> p = pessoas.GetEnumerator();
                IEnumerable<Pessoa> p2 = pessoas.AsEnumerable();

                comboBoxPessoas.ValueMember = "Id";
                comboBoxPessoas.DisplayMember = "Nome";
                comboBoxPessoas.DataSource = p2.ToList();
                comboBoxPessoas.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar  todas as Pessoas\n Mensagem de Erro: " + ex, "Cadastro de Ticket");

            }
        }

        private void PreencherListadeUsuarios()
        {
            try
            {


                List<Usuario> usuarios = new List<Usuario>();
                Usuario u = new Usuario();
                u.Nome = "Flavio";
                u.Id = 1;
                Usuario u1 = new Usuario();
                u1.Nome = "Matheus";
                u1.Id = 2;
                usuarios.Add(u1);
                usuarios.Add(u);
               

         
                IEnumerable<Pessoa> p2 = usuarios.AsEnumerable();

                comboBoxUsuario.ValueMember = "Id";
                comboBoxUsuario.DisplayMember = "Nome";
                comboBoxUsuario.DataSource = p2.ToList();
                comboBoxUsuario.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar  todas os Responsáveis\n Mensagem de Erro: " + ex, "Cadastro de Ticket");

            }
        }

        private ComboBox selecionarComboBox(CadastrosType type)
        {
            switch (type)
            {
                case CadastrosType.Servico: return comboBoxServicos;
                case CadastrosType.Urgencia: return comboBoxUrgencia;
                case CadastrosType.Status: return comboBoxStatus;

                default: throw new ArgumentOutOfRangeException();
            }
        }

        private void PreencherCombobox(CadastrosType type)
        {
            try
            {

                cadastoSimplesDao = CadastroSimplesDAO.GetInstancia(type);

                IEnumerable<ICadastro> cadastros = cadastoSimplesDao.ListarTudo();

                ComboBox box = selecionarComboBox(type);

                foreach (ICadastro c in cadastros)
                {
                    //FactoryCadastros.GetCadastro(type);
                    //box.Items.Insert(c.GetId(),c.GetNome());
                    box.Items.Add(c.GetNome());
                }

                box.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Buscar  todas os {type}\n Mensagem de Erro: " + ex, "Cadastro de Ticket");

            }
        }

        private void CadastroTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Usuario user = Login.GetUsuario();
            Mensagem mensagem = new Mensagem((itens_acoes.Count)+1, user.Id, user.Nome, DateTime.Now, txt_Mensagem.Text);


            itens_acoes.Add(mensagem);
            AcoesTickets acoes = new AcoesTickets(mensagem);


            flowLayoutPanel1.Controls.Add(acoes);
            txt_Mensagem.Text = "";
        }
    }
}
