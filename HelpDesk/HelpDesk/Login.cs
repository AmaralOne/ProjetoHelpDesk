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
    public partial class Login : Form
    {
        private static Login instancia = null;
        private static Usuario logado = null;

        public Login()
        {
            InitializeComponent();
        }

        public static Login GetInstancia()
        {

            if (instancia == null)
            {
                instancia = new Login();
            }


            return instancia;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Usuario GetUsuario()
        {
            return logado;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(1,"Flávio Filho",1,"Suporte","123");

            
            if (usuario.Autentificacao(txt_Nome.Text, txt_Senha.Text))
            {
                logado = usuario;
                Form1.GetInstancia(this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro no Login!!!\n Nome ou Senha estão incorretos.", "Login");

            }
            
        }
    }
}
