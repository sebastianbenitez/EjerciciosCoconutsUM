using System;
using Ejercicios28012020.Clases;

namespace Ejercicios28012020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 01:");
            var eje01 = new Ejercicio01();
            eje01.Fecha1 = new DateTime(2020, 01, 01);
            eje01.Fecha2 = new DateTime(2020, 01, 30);
            Console.WriteLine("Fecha1 = " + eje01.obtenerFechaFormateada(eje01.Fecha1));
            Console.WriteLine("Fecha2 = " + eje01.obtenerFechaFormateada(eje01.Fecha2));
            Console.WriteLine("Diferencia en dias = " + eje01.obtenerDiferenciaEnDias());
            Console.WriteLine("Diferencia en semanas = " + eje01.obtenerDiferenciaEnSemanas());


            Console.WriteLine("\nEjercicio 02:");
            var eje02 = new Ejercicio02();
            Console.WriteLine("calcularProducto(5,5) = " + eje02.calcularProducto(5,5));


            Console.WriteLine("\nEjercicio 03:");
            var eje03 = new Ejercicio03();
            Console.Write("obtenerMultiplos3(10) = ");
            foreach (var multiplo in eje03.obtenerMultiplos3(10))
            {
                Console.Write(multiplo + " ");
            }


            Console.WriteLine("\n\nEjercicio 04:");
            var eje04 = new Ejercicio04();
            int apuesta;
            do
            {
                Console.Write("Ingrese apuesta: ");
                apuesta = Convert.ToInt32(Console.ReadLine());
                eje04.agregarApuesta(apuesta);
            } while (apuesta >= 0 && apuesta < 37);
            
            eje04.girarRuleta();
            Console.WriteLine("\nNumero ganador = " + eje04.Ganador);
            Console.WriteLine("Cantidad Ganadores = " + eje04.obtenerCantidadGanadores());
            Console.WriteLine("Cantidad Perdedores = " + eje04.obtenerCantidadPerdedores());

            Console.ReadKey();
        }
    }
}
