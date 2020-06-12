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
    public partial class Form1 : Form
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
            CadastroPessoas.GetInstancia().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CadastroTicket.GetInstancia().Show();
        }
    }
}
