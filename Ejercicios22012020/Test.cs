using System;
using Ejercicios22012020.Clases;

namespace Ejercicios22012020
{
    class Test
    {
        static void Main(string[] args)
        {
            //Test Factorial
            Console.WriteLine("Ejercicio Factorial:");
            var factorial = new Factorial();
            Console.WriteLine("factorial.calcularFactorial(5) = " + factorial.calcularFactorial(5));
            Console.WriteLine("factorial.calcularFactorialRecursiva(5) = " + factorial.calcularFactorialRecursiva(5));

            //Test Fibonacci
            Console.WriteLine("\nEjercicio Fibonacci:");
            var fibo = new Fibonacci();
            Console.Write("fibo.obtenerSerie(8) = ");
            foreach (var numero in fibo.obtenerSerie(8))
            {
                Console.Write(numero + " ");
            }

            //Test Ingreso Numeros
            Console.WriteLine("\n\nEjercicio Ingreso Numeros:");
            var numeros = new IngresoNumeros();
            while(numeros.obtenerCantidadNumeros() < 10)
            {
                Console.Write("Ingrese numero(Restantes {0}): ", Math.Abs(numeros.obtenerCantidadNumeros()-10));
                try
                {
                    numeros.cargarNumero(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception)
                {
                    continue;
                }
            }
            Console.WriteLine("\nMayor: " + numeros.obtenerMayor());
            Console.WriteLine("Menor: " + numeros.obtenerMenor());
            Console.WriteLine("Suma: " + numeros.obtenerSuma());
            Console.WriteLine("Promedio: " + numeros.obtenerPromedio());

            Console.ReadKey();
        }
    }
}
