using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public interface IEntradaControler
    {
        void Create(EntradaDTO entradaDTO);//lo logico seria devolcer la Id o la entrada
        EntradaDTO Read(long id);//Entrada Leer(EntradaDTO entradaDTO);
        IList<EntradaDTO> ReadAll();
        void Update(EntradaDTO entradaDTO);//lo logico seria devolcer la Id o la Entrada

        void Delete(long id);
    }
}
