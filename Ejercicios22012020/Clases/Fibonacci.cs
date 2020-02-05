using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios22012020.Clases
{
    public class Fibonacci
    {
        public List<int> obtenerSerie(int cantidad)
        {
            var list = new List<int>();

            list.Add(1);
            if (cantidad == 1)
            {
                return list;
            }

            list.Add(2);
            if (cantidad == 2)
            {
                return list;
            }
            
            for (int i = 3; i <= cantidad; i++)
            {
                list.Add(list[list.Count - 1] + list[list.Count - 2]);
            }
            return list;
        }
    }
}
