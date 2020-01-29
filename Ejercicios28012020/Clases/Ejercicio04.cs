using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios28012020.Clases
{
    /*
        Hacer un programa que permita la carga de apuestas de ruleta. 
        Se pueden ingresar tantos números (entre 0 y 36) como se desee. 
        Se podrá indicar la finalización de la carga de las apuestas cargando un valor fuera del rango permitido.
        Al finalizar la carga, el programa deberá efectuar una tirada aleatoria en la que se obtenga 
        un número de la ruleta, siendo que cada número tiene la misma probabilidad de ser elegido.
        
        Se deberá informar:
        Cuantos ganadores hubo
        Cuantos perdedores hubo
    */
    class Ejercicio04
    {
        private List<int> _apuestas;
        private int _ganador;

        public Ejercicio04()
        {
            _apuestas = new List<int>();
            _ganador = 37;
        }

        public int Ganador
        {
            get
            {
                return _ganador;
            }
        }

        public void agregarApuesta(int apuesta)
        {
            if (apuesta >= 0 && apuesta < 37) _apuestas.Add(apuesta);
        }

        public void girarRuleta()
        {
            var random = new Random();
            _ganador = random.Next(0, 36);
        }

        public int obtenerCantidadGanadores()
        {
            var cantidadGanadores = 0;
            foreach (var apuesta in _apuestas)
            {
                if (apuesta == _ganador) cantidadGanadores++;
            }
            return cantidadGanadores;
        }
        public int obtenerCantidadPerdedores()
        {
            return _apuestas.Count - obtenerCantidadGanadores();
        }
    }
}
