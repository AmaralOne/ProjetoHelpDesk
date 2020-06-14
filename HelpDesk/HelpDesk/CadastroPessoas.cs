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
using DAO;

namespace HelpDesk
{
    public partial class CadastroPessoas : Form
    {
        private static CadastroPessoas instancia = null;
        private Boolean novo = true;
        private Boolean erro = false;

        private CadastroPessoas()
        {
            InitializeComponent();
            txt_Id.Enabled = false;
        }

        public static CadastroPessoas GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new CadastroPessoas();
            }

            return instancia;
        }

        private void InitializeDataGridView(IEnumerable<Pessoa> cadastros)
        {
            dataGridCadastro.Rows.Clear();
            dataGridCadastro.Refresh();

            // Create an unbound DataGridView by declaring a column count.
            dataGridCadastro.ColumnCount = 9;
            dataGridCadastro.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridCadastro.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridCadastro.Columns[0].Name = "Id";
            dataGridCadastro.Columns[1].Name = "Nome";
            dataGridCadastro.Columns[2].Name = "CPF";
            dataGridCadastro.Columns[3].Name = "Email";
            dataGridCadastro.Columns[4].Name = "Endereco";
            dataGridCadastro.Columns[5].Name = "Telefone";
            dataGridCadastro.Columns[6].Name = "Tipo";
            dataGridCadastro.Columns[7].Name = "Código Equipe";
            dataGridCadastro.Columns[8].Name = "Nome Equipe";

            dataGridCadastro.Columns[1].MinimumWidth = 270;
            dataGridCadastro.Columns[3].MinimumWidth = 200;

            // Populate the rows.

            foreach (Pessoa p in cadastros)
            {
                if(p.Tipo() == PessoaTipo.Pessoa)
                {
                    dataGridCadastro.Rows.Add(new string[] { p.Id.ToString(),
                    p.Nome,
                    p.CPF,
                    p.Email,
                    p.Endereco,
                    p.Telefone,
                    "Pessoa",
                    "",
                    ""});
                }
                else
                {
                    Usuario aux = (Usuario)p;
                    dataGridCadastro.Rows.Add(new string[] { p.Id.ToString(),
                    p.Nome,
                    p.CPF,
                    p.Email,
                    p.Endereco,
                    p.Telefone,
                    "Usuário",
                    aux.CodigoEquipe.ToString(),
                    aux.NomeEquipe});
                }
                
            }

        }

        private void CarregarGrind()
        {
            try
            {
                //var CCD = ControlFornecedor.TodasFornecedor();
                var pessoas = PessoaDAL.GetInstancia().ListarTudo();
                InitializeDataGridView(pessoas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar Todas Pessoas\n Mensagem de Erro: " + ex, "Cadastro de Pessoas");
            }


        }


        private void CadastroPessoas_Load(object sender, EventArgs e)
        {
            CarregarGrind();
            PreencherCombobox(CadastrosType.Equipe);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            dataGridCadastro.Enabled = false;
            btn_Novo.Enabled = false;
            txt_Nome.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_CPF.Enabled = true;
            txt_Email.Enabled = true;
            txt_telefone.Enabled = true;
            txt_Senha.Enabled = false;
            comboBoxEquipe.Enabled = false;
            checkBoxUsuario.Enabled = true;
            btn_Salvar.Enabled = true;
            txt_Nome.Focus();
            btn_Cancelar.Enabled = true;
            btn_Alterar.Enabled = false;
            btn_Deletar.Enabled = false;
            novo = true;

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            

            if (!txt_Nome.Text.Equals(""))
            {
                Pessoa model = null;
                bool erro = false;

                if (checkBoxUsuario.Checked == true)
                {
                    string equipe = comboBoxEquipe.SelectedValue.ToString();
                    string senha = txt_Senha.Text;

                    ICadastro equipe1 = CadastroSimplesDAO.GetInstancia(CadastrosType.Equipe).LocarizarPorNome(equipe);
                    if (equipe1 != null && !senha.Equals(""))
                    {
                        model = new Usuario(equipe1.GetId(), equipe1.GetNome(), senha);
                    }
                    else
                    {
                        erro = true;
                    }
                    
                }
                else
                {

                    string nome = txt_Nome.Text;
                    string cpf = txt_CPF.Text;
                    string telefone = txt_telefone.Text;
                    string email = txt_Email.Text;
                    string endereco = txt_Endereco.Text;

                    model = new Pessoa(nome,cpf,telefone,email,endereco);

                    PessoaDAO.GetInstancia(PessoaTipo.Pessoa).Inserir(model);
                }

                model.Nome = txt_Nome.Text;
                model.CPF = txt_CPF.Text;
                model.Email = txt_Email.Text;
                model.Endereco = txt_Endereco.Text;
                model.Telefone = txt_telefone.Text;
 
               
                if(erro && Pessoa.ValidaEmail(model.Email) && Pessoa.ValidaTelefone(model.Telefone))
                {
                          
                     if (novo)
                     {
                         try
                         {
                                //cadastoSimplesDao.Inserir(model);
                         }
                         catch (Exception ex)
                         {
                                MessageBox.Show($"Erro ao incluir Pessoa\n Mensagem de erro: " + ex, $"Cadastro de Pessoa");
                         }
                     }
                     else
                     {


                         try
                         {
                                //cadastoSimplesDao.Atualizar(model);
                         }
                         catch (Exception ex)
                         {
                                MessageBox.Show($"Erro ao alterar Pessoa\n Mensagem de erro: " + ex, $"Cadastro de Pessoa");
                         }

                     }
               
                }
                else
                {
                     MessageBox.Show($"Erro ao Salvar Pessoa\n Mensagem de erro: Algum dado do cadastro está invalido", $"Cadastro de Pessoa");

                }

            CarregarGrind();

            bloquear();
            }
            else
            {
                MessageBox.Show($"Erro!!!\nCampo Nome Inválido!!!", $"Cadastro de Pessoa");
            }
        }

        private void PreencherCombobox(CadastrosType type)
        {
            try
            {

                CadastroSimplesDAO cadastoSimplesDao = CadastroSimplesDAO.GetInstancia(type);

                IEnumerable<ICadastro> cadastros = cadastoSimplesDao.ListarTudo();

                foreach (ICadastro c in cadastros)
                {

                    comboBoxEquipe.Items.Add(c.GetNome());
                }

                comboBoxEquipe.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Buscar  todas as Equipes\n Mensagem de Erro: " + ex, "Cadastro de Pessoa");

            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Id.Text = dataGridCadastro.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = dataGridCadastro.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro!!!\nCadastre uma Pessoa para poder Alterar", $"Cadastro de Pessoas");
                erro = true;
            }



            if (erro == false)
            {
                dataGridCadastro.Enabled = false;
                btn_Novo.Enabled = false;
                txt_Nome.Enabled = true;
                txt_Endereco.Enabled = true;
                txt_CPF.Enabled = true;
                txt_Email.Enabled = true;
                txt_telefone.Enabled = true;
                txt_Senha.Enabled = false;
                comboBoxEquipe.Enabled = false;
                checkBoxUsuario.Enabled = true;
                btn_Salvar.Enabled = true;
                txt_Nome.Focus();
                btn_Cancelar.Enabled = true;
                btn_Alterar.Enabled = false;
                btn_Deletar.Enabled = false;

                novo = false;
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            Pessoa model = new Pessoa();
            erro = false;
            try
            {
                model.Id = (int.Parse(dataGridCadastro.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro!!!\nCadastre uma Pessoa para poder Deletar", $"Cadastro de Pessoas");
                erro = true;
            }

            if (erro == false)
            {
                try
                {
                    PessoaDAO.GetInstancia(PessoaTipo.Pessoa).Remover(model);
                    CarregarGrind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar Deletar Item!!!\nVerifique se ele esta sendo usado", $"Cadastro de Pessoas");

                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            bloquear();
        }

        private void bloquear()
        {
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Deletar.Enabled = true;
            btn_Alterar.Enabled = true;
            btn_Cancelar.Enabled = false;
            dataGridCadastro.Enabled = true;

            txt_Id.Text = "";
            txt_Nome.Text = "";
            txt_Nome.Enabled = false;

            txt_Endereco.Enabled = false;
            txt_Endereco.Text = "";

            txt_CPF.Enabled = false;
            txt_CPF.Text = "";

            txt_Email.Enabled = false;
            txt_Email.Text = "";

            txt_telefone.Enabled = false;
            txt_telefone.Text = "";

            txt_Senha.Enabled = false;
            txt_Senha.Text = "";

            comboBoxEquipe.Enabled = false;
            //comboBoxEquipe.SelectedIndex = 0;

            checkBoxUsuario.Enabled = false;
            checkBoxUsuario.Checked = false;

        }

        private void CadastroPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void txt_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string pesquisa = txt_pesquisa.Text;
                IEnumerable<Pessoa> cadastros = PessoaDAO.GetInstancia(PessoaTipo.Pessoa).ListarPorParametros(pesquisa);


                InitializeDataGridView(cadastros);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Pesquisar Pessoa\n Mensagem de Erro: " + ex, $"Cadastro de Pessoa");
            }
        }

        private void checkBoxUsuario_TextChanged(object sender, EventArgs e)
        {
           
                
        }

        private void checkBoxUsuario_Click(object sender, EventArgs e)
        {
            if (checkBoxUsuario.Checked == true)
            {
                txt_Senha.Enabled = true;
                comboBoxEquipe.Enabled = true;
            }
            else
            {
                txt_Senha.Enabled = false;
                comboBoxEquipe.Enabled = false;
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
