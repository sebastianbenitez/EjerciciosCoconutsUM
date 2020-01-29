using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios28012020.Clases
{
    /*
        Realizar un programa que permita el ingreso de 2 fechas y muestre los resultados:
        - Muestre ambas fechas en la pantalla en formato legible (Lunes, 17 de mayo de 20…)
        - días de diferencia entre ambas fechas
        - Semanas de diferencia entre ambas fechas 
    */
    class Ejercicio01
    {
        public DateTime Fecha1
        {
            get;
            set;
        }
        public  DateTime Fecha2
        {
            get;
            set;
        }

        public string obtenerFechaFormateada(DateTime fecha)
        {
            return fecha.ToString("dddd, d 'de' MMMM 'de' yyyy");
        }
        public int obtenerDiferenciaEnDias()
        {
            return ((TimeSpan)(Fecha2 - Fecha1)).Days;
        }
        public int obtenerDiferenciaEnSemanas()
        {
            return obtenerDiferenciaEnDias() / 7;
        }
    }
}
