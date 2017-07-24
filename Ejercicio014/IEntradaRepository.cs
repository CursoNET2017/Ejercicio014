using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public interface IEntradaRepository
    {
        void Create(Entrada entrada);//lo logico seria devolcer la Id o la entrada
        Entrada Read(long id);//Entrada Leer(Entrada entrada);
        IList<Entrada> ReadAll();
        void Update(Entrada entrada);//lo logico seria devolcer la Id o la Entrada

        void Delete(long id);
    }
}
