using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Interfaces_Grupo9_Ej2
{
    class Pato : Animal, Ivolador
    {
        private int energia = 100;

        public void volador()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuack!");
        }

        public int Energia { get => energia; set => energia = value; }

    }
}
