using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios22012020.Clases
{
    class IngresoNumeros
    {
        List<int> _listaNumeros;
        public IngresoNumeros()
        {
            _listaNumeros = new List<int>();
        }


        private bool validarNumero(int numero)
        {
            return numero >= 0 && numero <= 100;
        }
        public void cargarNumero(int numero)
        {
            // si el numero pasado es valido (mayor a 0, menor a 100) se agrega a la lista de numeros
            if (validarNumero(numero)) _listaNumeros.Add(numero);
        }
        public int obtenerCantidadNumeros()
        {
            return _listaNumeros.Count;
        }


        private IEnumerable<int> obtenerEnumerable()
        {
            /* 
             * se retorna un casteo implicito del List<int> a IEnumerable<int>
             * esto permite aplicarle funciones especificas que son proveidas por el lenguaje
            */
            return _listaNumeros;
        }
        public int obtenerMayor()
        {
            return obtenerEnumerable().Max();
        }
        public int obtenerMenor()
        {
            return obtenerEnumerable().Min();
        }
        public double obtenerPromedio()
        {
            return obtenerEnumerable().Average();
        }
        public int obtenerSuma()
        {
            return obtenerEnumerable().Sum();
        }
    }
}
