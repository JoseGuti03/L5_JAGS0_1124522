using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_JAGS0_1124522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;

            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ingrese el numero entero");

            numeroEntero = Convert.ToInt32(Console.ReadLine());

            if (numeroEntero > 0)
            {
                Console.WriteLine("Resultado : Positivo");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("Resultdo : Negativo");
            }

            else if (numeroEntero == 0)
            {
                Console.WriteLine("Resultdo : el valor ingreado es cero");
            }
            Console.ReadKey();
    }
    }
}
