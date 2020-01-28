using System;
using Soluciones.Clases;

namespace Soluciones
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = new Factorial();
            Console.WriteLine(factorial.calcularFactorial(5));
            Console.WriteLine(factorial.calcularFactorialRecursiva(5));
            Console.ReadKey();
        }
    }
}
