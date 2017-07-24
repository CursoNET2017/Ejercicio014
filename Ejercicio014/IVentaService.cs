using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public interface IVentaService
    {
        void Create(Venta venta);//lo logico seria devolcer la Id o la venta
        Venta Read(long id);//Venta Leer(Venta venta);
        IList<Venta> ReadAll();
        void Update(Venta venta);//lo logico seria devolcer la Id o la venta

        void Delete(long id);
    }
}
