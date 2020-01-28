using System;
using System.Collections.Generic;
using System.Text;

namespace Soluciones.Clases
{
    public class Factorial
    {
        public int calcularFactorial(int numero)
        {
            int factorial = 1;
            for (int i = numero; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int calcularFactorialRecursiva(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            return numero * calcularFactorialRecursiva(numero - 1);
        }
    }
}
