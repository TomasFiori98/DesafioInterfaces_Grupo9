using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9
{
    class Foto : Impresora, Iimprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy una foto pal insta.");
        }
    }
}
