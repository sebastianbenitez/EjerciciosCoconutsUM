using System;
using System.Collections.Generic;
using System.Text;

namespace Soluciones.Clases
{
    class IngresoNumeros
    {
        List<int> _numeros;
        public IngresoNumeros()
        {
            _numeros = new List<int>();
        }

        private bool validarNumero(int numero)
        {
            if (numero < 0 || numero > 100) return false;
            return true;
        }
        public void cargarNumero(int numero)
        {
            if (validarNumero(numero)) _numeros.Add(numero);
        }
        public int cantidadNumeros()
        {
            return _numeros.Count;
        }
        public int obtenerMayor()
        {
            return 0;
        }
        public int obtenerMenor()
        {
            return 0;
        }
        public int obtenerPromedio()
        {
            return 0;
        }
        public int obtenerSuma()
        {
            return 0;
        }
    }
}
