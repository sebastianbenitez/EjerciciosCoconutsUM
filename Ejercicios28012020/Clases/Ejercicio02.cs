using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios28012020.Clases
{
    /*
        Dados dos valores numéricos enteros, calcular e informar su producto mediante sumas sucesivas. 
    */
    class Ejercicio02
    {
        public int calcularProducto(int n1, int n2)
        {
            int producto = 0;
            for (int i = 0; i < n1; i++)
            {
                producto += n2;
            }
            return producto;
        }
    }
}
