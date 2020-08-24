using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Entrada
    {
        public string Funcion { get; set; }
        public int Iteraciones { get; set; }
        public double Tolerancia { get; set; }
        public double X_Der { get; set; }
        public double X_Izq { get; set; }
    }
}
