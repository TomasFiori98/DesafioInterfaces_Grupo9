using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato c = new Contrato();
            Foto f = new Foto();
            Documento d = new Documento();

            Impresora i = new Impresora();

            i.AgregarImprimible(c);
            i.AgregarImprimible(f);
            i.AgregarImprimible(d);

            i.ImprimirTodo();

            Console.ReadKey();
        }
    }
}
