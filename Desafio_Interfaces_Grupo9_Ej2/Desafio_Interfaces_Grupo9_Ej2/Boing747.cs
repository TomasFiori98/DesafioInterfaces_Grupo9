using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9_Ej2
{
    class Boing747 : Avion, Ivolador
    {
        private int horasDeVuelo = 0;

        public void volador()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un avion...");
        }

        public int HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }

    }
}
