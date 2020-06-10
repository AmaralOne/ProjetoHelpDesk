using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FactoryCadastros
    {
        public static ICadastro GetCadastro(CadastrosType type)
        {
            switch (type)
            {
                case CadastrosType.Equipe: return new Equipe();
                case CadastrosType.Status: return new Status();
                case CadastrosType.Servico: return new Servico();
                case CadastrosType.Urgencia: return new Urgencia();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
