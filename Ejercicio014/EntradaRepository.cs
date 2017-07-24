using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    public class EntradaRepository : IEntradaRepository
    {
        private IList<Entrada> Listado = new List<Entrada>();//Hay que hacerlo mas general, con las interfaces

        public void Create(Entrada entrada)
        {
            Listado.Add(entrada);
        }

        public void Delete(long id)
        {
            foreach (Entrada item in Listado)
            {
                if (item.Id.Equals(id))
                {
                    Listado.Remove(item);
                }
            }
        }

        public Entrada Read(long id)
        {
            foreach (Entrada item in Listado)
            {
                if (item.Id.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        public IList<Entrada> ReadAll()
        {
            return Listado;
        }

        public void Update(Entrada entrada)
        {
            foreach (Entrada item in Listado)
            {
                if (item.Id.Equals(entrada.Id))
                {
                    item.Id = entrada.Id;
                }
            }
        }
    }
}
