using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace HelpDesk
{
    public partial class AcoesTickets : UserControl
    {
        private Acoes acoes = null;
        public AcoesTickets(Acoes acoes)
        {
            InitializeComponent();
            this.acoes = acoes;
            btn_Arquivo.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AcoesTickets_Load(object sender, EventArgs e)
        {
            lab_id.Text = acoes.Id.ToString();
            lab_data.Text = acoes.Data.ToString();
            lab_Usuario.Text = acoes.NomeUsuario;
            lab_Mensagem.Text = acoes.Exibir();

            if(acoes.Tipo() == AcoesEnum.Arquivo)
            {
                btn_Arquivo.Enabled = true;
                btn_Arquivo.Visible = true;
            }
        }

        private void btn_Arquivo_Click(object sender, EventArgs e)
        {
            Arquivo aux = (Arquivo)acoes;
            string pathFile = aux.Caminho + "\\" + aux.Nome+"."+aux.Formato;
            System.Diagnostics.Process.Start(pathFile);
        }
    }
}
