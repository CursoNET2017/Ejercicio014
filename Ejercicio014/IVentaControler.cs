using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public interface IVentaControler
    {
        void Create(VentaDTO ventaDTO);//lo logico seria devolcer la Id o la venta
        VentaDTO Read(long id);//VentaDTO Leer(VentaDTO ventaDTO);
        IList<VentaDTO> ReadAll();
        void Update(VentaDTO ventaDTO);//lo logico seria devolcer la Id o la venta

        void Delete(long id);

    }
}
