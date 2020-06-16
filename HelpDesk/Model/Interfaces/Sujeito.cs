using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface Sujeito
    {
        void incluir(Observador o);
        void remover(Observador o);
        void notificarObservador();
    }
}
