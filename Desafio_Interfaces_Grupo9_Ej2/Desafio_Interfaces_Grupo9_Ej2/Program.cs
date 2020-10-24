using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato p = new Pato();
            Boing747 b = new Boing747();
            Superman s = new Superman();

            TorreDeControl t = new TorreDeControl();

            t.agregarVolador(p);
            t.agregarVolador(b);
            t.agregarVolador(s);

            t.vuelenTodos();

            Console.ReadKey();

        }
    }
}
