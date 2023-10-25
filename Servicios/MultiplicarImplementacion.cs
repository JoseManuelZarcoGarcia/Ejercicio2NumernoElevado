using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2NumernoElevado.Servicios
{
    internal class MultiplicarImplementacion : MultiplicarInterfaz
    {

        public void multiplicaYMuestra(double numeroPedido1, double numeroPedido2)
        {
            double aux = numeroPedido1;

            for (int i = 1; i < numeroPedido2; i++)
            {
                aux = aux * numeroPedido1;
            }

            Console.WriteLine("El resultado de multiplicar {0} por si mismo unas {1} es: {2}",numeroPedido1,numeroPedido2 , aux);
        }

    }
}
