﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public interface IVentaConverter
    {
        VentaDTO EntityToDTO(Venta venta);
        Venta DTOToEntity(VentaDTO ventaDTO);
    }
}
