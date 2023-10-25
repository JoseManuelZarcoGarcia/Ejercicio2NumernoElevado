using Ejercicio2NumernoElevado.Servicios;

namespace Ejercicio2NumernoElevado.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            MultiplicarInterfaz mi = new MultiplicarImplementacion();
            PreguntaInterfaz pi = new PreguntaImplemetacion();
            double num1, num2;

            num1 = pi.pedirNumero();
            num2 = pi.pedirNumero();

            mi.multiplicaYMuestra(num1, num2);
            
        }

    }

}