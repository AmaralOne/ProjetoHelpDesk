using DAO;

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            CadastroSimples.GetInstancia(Model.CadastrosType.Equipe).Show();
            

        }

        private void btn_Cadastro_Status_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Status).Show();
        }

        private void btn_Cadastro_Urgencia_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Urgencia).Show();
        }

        private void btn_Cadastro_Servico_Click(object sender, EventArgs e)
        {
            CadastroSimples.GetInstancia(Model.CadastrosType.Servico).Show();
        }

        private void btn_NovoTicket_Click(object sender, EventArgs e)
        {
            CadastroTicket.GetInstancia().Show();
        }
    }
}
