using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Ticket ticket = null;



        private CadastroTicket(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
        }


        public static CadastroTicket GetInstancia(Ticket ticket= null)
        {

            if (instancia == null)
            {
                instancia = new CadastroTicket(ticket);
            }

            

            return instancia;
        }

        private IEnumerable<object> GetItems(IEnumerable<ICadastro> cadastros)
        {
            foreach(ICadastro c in cadastros)
            {
                yield return new { Text = c.GetNome(), Value = c.GetId() };
            }

        }

        private void CadastroTicket_Load(object sender, EventArgs e)
        {

            PreencherListadePessoas();
            PreencherListadeUsuarios();
            PreencherCombobox(CadastrosType.Status);
            PreencherCombobox(CadastrosType.Urgencia);
            PreencherCombobox(CadastrosType.Servico);

            if(ticket != null)
            {
                novo = false;
                txt_Assunto.Text = ticket.Assunto;
                comboBoxPessoas.SelectedValue = ticket.CodigoPessoa;
                comboBoxPessoas.Text = ticket.NomePessoa;
                comboBoxUsuario.SelectedValue = ticket.CodigoResponsavel;
                comboBoxUsuario.Text = ticket.NomeResponsavel;
                comboBoxStatus.SelectedValue = ticket.CodigoStatus;
                comboBoxServicos.SelectedValue = ticket.CodigoServico;
                comboBoxUrgencia.SelectedValue = ticket.CodigoUrgencia;
                dateTimePrevisao.Value = ticket.PrevisaoTermico;

                foreach(Acoes a in ticket.ListaAcoes)
                {
                    flowLayoutPanel1.Controls.Add(new AcoesTickets(a));
                }

                itens_acoes = ticket.ListaAcoes.ToList();
            }
            else
            {
                ticket = new Ticket();
            }

            
        }

        private void PreencherListadePessoas()
        {
            try
            {


                List<Pessoa> pessoas = new List<Pessoa>();
                /*
                pessoas.Add(new Pessoa(1, "Flávio","222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(2, "Joao", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(3, "Victor", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(4, "Maria", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(5, "Luis", "222", "9999", "f@f.com", "e"));
                pessoas.Add(new Pessoa(6, "Karol", "222", "9999", "f@f.com", "e"));
                */
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
                GetItems(cadastros);
                ComboBox box = selecionarComboBox(type);

                //foreach (ICadastro c in cadastros)
                //{
                    //FactoryCadastros.GetCadastro(type);
                    //box.Items.Insert(c.GetId(),c.GetNome());
                 //   box.Items.Add(c.GetNome());
                //}

                box.DisplayMember = "Text";
                box.ValueMember = "Value";

                box.DataSource = GetItems(cadastros).ToList();

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

        private void btn_Anexar_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog

            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                string path = openFileDialog1.FileName;
                string Name = openFileDialog1.SafeFileName;
                string[] aux = Name.Split('.');
                string nome = aux[0];
                string formato = aux[1];
                string caminho = Path.GetDirectoryName(path);

                Usuario user = Login.GetUsuario();
                Arquivo arquivo  = new Arquivo((itens_acoes.Count) + 1, user.Id, user.Nome, DateTime.Now,caminho,nome,formato);

                itens_acoes.Add(arquivo);
                AcoesTickets acoes = new AcoesTickets(arquivo);
                flowLayoutPanel1.Controls.Add(acoes);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (!txt_Assunto.Text.Equals(""))
            {

                if (comboBoxPessoas.Text.Equals("") || comboBoxPessoas.SelectedValue == null)
                {
                    erro = true;
                    MessageBox.Show($"Erro ao Salvar Ticket\n Mensagem de erro: Deve Selecionar uma Pessoa", $"Cadastro de Ticket");

                }

                if (comboBoxUsuario.Text.Equals("") || comboBoxUsuario.SelectedValue == null)
                {
                    erro = true;
                    MessageBox.Show($"Erro ao Salvar Ticket\n Mensagem de erro: Deve Selecionar um Responsável", $"Cadastro de Ticket");

                }
                


                if (erro == false)
                {
                    
                    int idPessoa = (int)comboBoxPessoas.SelectedValue;
                    int idUsuario = (int)comboBoxUsuario.SelectedValue;
                    int idSevicos = (int)comboBoxServicos.SelectedValue;
                    int idStatus = (int)comboBoxStatus.SelectedValue;
                    int idUrgencia = (int)comboBoxUrgencia.SelectedValue;
                    ticket.CodigoPessoa = idPessoa;
                    ticket.CodigoResponsavel = idUsuario;
                    ticket.CodigoServico = idSevicos;
                    ticket.CodigoStatus = idStatus;
                    ticket.CodigoUrgencia = idUrgencia;
                    ticket.Assunto = txt_Assunto.Text;
                    ticket.DataAlteracao = DateTime.Now;
                    ticket.PrevisaoTermico = dateTimePrevisao.Value;


                    ticket.ListaAcoes = itens_acoes.AsEnumerable();
                    if (novo)
                    {
                        ticket.DataInicio = DateTime.Now;
                        try
                        {
                            //cadastoSimplesDao.Inserir(model);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao incluir Ticket\n Mensagem de erro: " + ex, $"Cadastro de Ticket");
                        }
                    }
                    else
                    {


                        try
                        {
                            //cadastoSimplesDao.Atualizar(model);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao alterar Ticket\n Mensagem de erro: " + ex, $"Cadastro de Ticket");
                        }

                    }

                }
                

            }
            else
            {
                MessageBox.Show($"Erro!!!\nAssunto deve ser preecnido", $"Cadastro de Ticket");
            }
        }

        private void comboBoxPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
