using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9_Ej2
{
    class Superman : SuperHeroe, Ivolador
    {
        private int experiencia = 0;

        public void volador()
        {
            experiencia += 3;
            Console.WriteLine("Estoy volando como un campeon...");
        }

        public int Experiencia { get => experiencia; set => experiencia = value; }

    }
}
