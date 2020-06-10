using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICadastro
    {
        int GetId();
        string GetNome();
        void SetId(int id);
        void SetNome(string Nome);
    }
}
