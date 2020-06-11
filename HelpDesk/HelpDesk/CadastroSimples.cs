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
    public partial class CadastroSimples : Form
    {
        private static CadastroSimples instancia = null;
        private static CadastrosType type;
        private Boolean novo = true;
        private Boolean erro = false;
        private CadastroSimplesDAO cadastoSimplesDao = null;
        private CadastroSimples()
        {
            InitializeComponent();
            this.Text = $"Cadastro de {type}";
        }

        public static CadastroSimples GetInstancia(CadastrosType t)
        {
            type = t;
            if (instancia == null)
            {
                instancia = new CadastroSimples();
            }
            

            return instancia;
        }

        private void CadastroSimples_Load(object sender, EventArgs e)
        {
            CarregarGrind();
        }

        private void CarregarGrind()
        {
            try
            {
                cadastoSimplesDao = CadastroSimplesDAO.GetInstancia(type);

                IEnumerable<ICadastro> cadastros = cadastoSimplesDao.ListarTudo();

                //dataGridCadastro.DataSource = cadastros;
                
                InitializeDataGridView(cadastros);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Buscar Todos {type}\n Mensagem de Erro: " + ex, $"Cadastro de {type}");
            }


        }

        private void InitializeDataGridView(IEnumerable<ICadastro> cadastros)
        {
            dataGridCadastro.Rows.Clear();
            dataGridCadastro.Refresh();

            // Create an unbound DataGridView by declaring a column count.
            dataGridCadastro.ColumnCount = 2;
            dataGridCadastro.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridCadastro.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridCadastro.Columns[0].Name = "Id";           
            dataGridCadastro.Columns[1].Name = "Nome";
            dataGridCadastro.Columns[1].MinimumWidth = 270;

            // Populate the rows.

            foreach(ICadastro c in cadastros)
            {
                dataGridCadastro.Rows.Add(new string[] { c.GetId().ToString(),
                    c.GetNome()});
            }

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            dataGridCadastro.Enabled = false;
            btn_Novo.Enabled = false;
            txt_Nome.Enabled = true;
            btn_Salvar.Enabled = true;
            txt_Nome.Focus();
            btn_Cancelar.Enabled = true;
            btn_Alterar.Enabled = false;
            btn_Deletar.Enabled = false;
            novo = true;
        }

        private void CadastroSimples_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
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
                MessageBox.Show($"Erro!!!\nCadastre um {type} para poder Alterar", $"Cadastro de {type}");
                erro = true;
            }

 

            if (erro == false)
            {
                txt_Nome.Enabled = true;
                txt_Nome.Focus();
                btn_Novo.Enabled = false;
                btn_Salvar.Enabled = true;
                dataGridCadastro.Enabled = false;
                btn_Alterar.Enabled = false;
                btn_Deletar.Enabled = false;
                btn_Cancelar.Enabled = true;
                
                novo = false;
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            ICadastro model = FactoryCadastros.GetCadastro(type);
            erro = false;
            try
            {
                model.SetId(int.Parse(dataGridCadastro.CurrentRow.Cells[0].Value.ToString()));
                model.SetNome(dataGridCadastro.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show($"Erro!!!\nCadastre um {type} para poder Deletar", $"Cadastro de {type}");
                erro = true;
            }

            if (erro == false)
            {
                try
                {
                    cadastoSimplesDao.Remover(model);
                    CarregarGrind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar Deletar Item!!!\nVerifique se ele esta sendo usado", $"Cadastro de {type}");

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
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ICadastro model = FactoryCadastros.GetCadastro(type);

            if (!txt_Nome.Text.Equals(""))
            {

                if (novo)
                {
                    model.SetNome(txt_Nome.Text);

                    try
                    {
                        cadastoSimplesDao.Inserir(model);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao incluir {type}\n Mensagem de erro: " + ex, $"Cadastro de {type}");
                    }

                }
                else
                {
                    model.SetId(int.Parse(txt_Id.Text));
                    model.SetNome(txt_Nome.Text);

                    try
                    {
                        cadastoSimplesDao.Atualizar(model);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao alterar {type}\n Mensagem de erro: " + ex, $"Cadastro de {type}");
                    }

                }



                CarregarGrind();

                bloquear();
            }
            else
            {
                MessageBox.Show($"Erro!!!\nCampo Nome Inválido!!!", $"Cadastro de {type}");
            }
        }

        private void txt_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string pesquisa = txt_pesquisa.Text;
                IEnumerable<ICadastro> cadastros = cadastoSimplesDao.ListarPorParametros(pesquisa);

                
                InitializeDataGridView(cadastros);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Pesquisar {type}\n Mensagem de Erro: " + ex, $"Cadastro de {type}");
            }
        }
    }
}
