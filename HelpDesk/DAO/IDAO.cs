using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IDAO<T>:IDisposable
        where T: class, new()
    {
        //método para inserir
        T Inserir(T Model);

        //método para atualizar
        void Atualizar(T Model);

        //método para remover
        bool Remover(T Model);

        //método para procurar registros especifico

        T LocarizarPorCodigo(params Object[] Keys);

        //método para listar tudo
        IEnumerator<T> ListarTudo();

        //método para listar todos itens por párametro
        IEnumerator<T> ListarPorParametros(params Object[] Keys);
    }
}
