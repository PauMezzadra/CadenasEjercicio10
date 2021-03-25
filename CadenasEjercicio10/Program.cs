using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            do
            {
                Console.WriteLine("Ingrese un texto y yo se lo mostraré en minúsculas");
                texto = Console.ReadLine().ToLower();
                if (texto == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
                else
                {
                    Console.WriteLine($"Su frase es: {texto}");
                }
            } while (texto == "");

            Console.ReadKey();
        }
    }
}
