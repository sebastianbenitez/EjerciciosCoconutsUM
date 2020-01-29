using System;
using Ejercicios28012020.Clases;

namespace Ejercicios28012020
{
    class Program
    {
        static void Main(string[] args)
        {
            var eje02 = new Ejercicio02();
            Console.WriteLine("\nEjercicio 02:");
            Console.WriteLine("calcularProducto(5,5) = " + eje02.calcularProducto(5,5));

            var eje03 = new Ejercicio03();
            Console.WriteLine("\nEjercicio 03:");
            Console.Write("obtenerMultiplos3(10) = ");
            foreach (var multiplo in eje03.obtenerMultiplos3(10))
            {
                Console.Write(multiplo + " ");
            }

            Console.ReadKey();
        }
    }
}
