using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class CadastroSimplesControl
    {
        private static CadastroSimplesControl instancia = null;
        private static CadastrosType type;
        private CadastroSimplesControl() { }

        public static CadastroSimplesControl GetInstancia(CadastrosType type_Cadastro)
        {
            if(instancia == null)
            {
                instancia = new CadastroSimplesControl();
            }
            type = type_Cadastro;
            return instancia;
        }

        public static void IncluirModel(ICadastro model)
        {
            try
            {

            }catch( Exception e)
            {
                throw e;
            }


               


        }
    }
}
