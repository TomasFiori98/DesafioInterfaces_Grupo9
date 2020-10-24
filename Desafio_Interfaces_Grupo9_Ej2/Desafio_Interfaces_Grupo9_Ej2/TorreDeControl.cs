using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9_Ej2
{
    class TorreDeControl
    {
        List<Ivolador> voladores = new List<Ivolador>();

        public void vuelenTodos()
        {
            foreach (Ivolador v in voladores)
            {
                v.volador();
            }
        }

        public void agregarVolador(Ivolador unVolador)
        {
            voladores.Add(unVolador);
        }

    }
}
