using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suma(4, 3);
            Saludo("Doni", 'd');
            Console.WriteLine(Resta(10, 5));
            Console.WriteLine(Dividir(24, 6));
            Console.WriteLine(DividirNumero(24, 6));
        }
        /*Los metodos son funciones dentro de un objeto, es un nombre por convencion.*/
        /*Cuando usamos void, nunca nos va a devolver nada por eso usamos console.writeLine
        El metodo nunca se va a ejecutar hasta que sea llamado en el metodo Main. Podemos
        crear un metodo con o sin parametros, si usamos este ultimo los declaramos en el 
        metodo Main*/
        static void Suma(int num1, int num2)
        {
            Console.WriteLine($"El resultado de la suma es {num1 + num2}");
        }

        static void Saludo(string nombre, char letra)
        {
            Console.WriteLine($"Tú nombre es {nombre} y empieza con la letra {letra}");
        }

        /*Cuando creamos un metodo "return" debemos indicar el tipo de dato primitivo. Ese 
        dato debe coincidir con los datos que pasamos en los parametros, de lo contrario 
        lanzara un error. Si el dato del metodo es int y en los paramatros tenemos un Double 
        y un Int, ganara el Double y éste no coincidirá con el dato Int del metodo.
        Cuando llamamos al metodo en el Main, debemos indicar que hacer con el valor 
        devuelto por return, de lo contrario el metodo no hara nada(por ej.:imprimirlo en
        pantalla por console.writeline). */

        static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        /*MODULAR EL CODIGO. Simplificar el codigo, no hacerlo tan extenso y mas 
        legible. Para eso existe la funcion flecha, que es igual a declarar una funcion
        convensional, solo que mas simplificada y siempre q sea de una sola linea.*/

        static double Dividir(double num1, int num2)
        {
            double resultado = num1 / num2;
            return resultado;
        }

        /*FUNCION FLECHA DEL METODO ANTERIOR, sin embargo si necesitaramos usar la 
        variable resultado en nuestro programa, esta funcion flecha no nos servirá.
        Por esa razon es mas optimo aplicarlo en metodos de una linea de codigo como
        en el caso del metodo Resta*/
        static double DividirNumero(double num1, double num2) => num1 / num2;
    }
    
    
}

