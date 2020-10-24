using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9
{
    class Impresora
    {

        List<Iimprimible> colaDeImpresion = new List<Iimprimible>();

        public void ImprimirTodo()
        {
            foreach (Iimprimible i in colaDeImpresion)
            {
                i.imprimir();
            }
        }
        public void AgregarImprimible(Iimprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);
        }


    }
}
