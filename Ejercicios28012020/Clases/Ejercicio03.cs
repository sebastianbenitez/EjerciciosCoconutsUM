using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios28012020.Clases
{
    /*
        Dado un valor numérico entero m, determinar e 
        imprimir un listado con los m primeros múltiplos de 3 que no sean múltiplos de 5 
    */
    class Ejercicio03
    {
        public List<int> obtenerMultiplos3(int cantidad)
        {
            var multiplo3 = 3;
            var multiplos3 = new List<int>();

            while(multiplos3.Count < cantidad)
            {
                if (!esMultiplo5(multiplo3)) multiplos3.Add(multiplo3);
                multiplo3 += 3;
            }
            return multiplos3;
        }

        private bool esMultiplo5(int numero)
        {
            return numero % 5 == 0;
        }
    }
}
