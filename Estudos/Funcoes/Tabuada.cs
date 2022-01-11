using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Funcoes
{
    class Tabuada
    {
        public static void Calcular(int numeroTabuada)
        {
            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine(numeroTabuada + " X " + i + " = " + (numeroTabuada*i) + "\n");
            }
        }
    }
}
