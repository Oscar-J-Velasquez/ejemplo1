using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hola, como estas? Por favor ingresa tu nombre.");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", listo para empezar a programar?");
            Console.WriteLine("¿Cuantos años tenes?");
            int edad = int.Parse(Console.ReadLine());
            int edadAumentada = edad + 5;
            Console.WriteLine("Si le sumo 5 años a tu edad actual, el resultado seria " + edadAumentada + " años.");

            
        }
    }
}
