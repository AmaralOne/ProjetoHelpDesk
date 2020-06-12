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

        private void CarregarGrind()
        {
            try
            {
                //var CCD = ControlFornecedor.TodasFornecedor();
                //GridItensFornecedor.DataSource = CCD;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar Todas Pessoas\n Mensagem de Erro: " + ex, "Cadastro de Pessoas");
            }


        }


        private void CadastroPessoas_Load(object sender, EventArgs e)
        {

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
                   // cadastoSimplesDao.Remover(model);
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
            comboBoxEquipe.SelectedIndex = 0;

            checkBoxUsuario.Enabled = true;
            checkBoxUsuario.Checked = false;

        }
    }
}
