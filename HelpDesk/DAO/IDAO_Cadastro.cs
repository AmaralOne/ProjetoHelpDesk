using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface IDAO_Cadastro
    {
        ICadastro Inserir(ICadastro Model);

        //método para atualizar
        void Atualizar(ICadastro Model);

        //método para remover
        void Inativar(ICadastro Model);

        //método para procurar registros especifico

        ICadastro LocarizarPorCodigo(params Object[] Keys);

        //método para listar tudo
        IEnumerator<ICadastro> ListarTudo();

        //método para listar todos itens por párametro
        IEnumerator<ICadastro> ListarPorParametros(params Object[] Keys);
    }
}
