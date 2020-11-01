using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.Unidad_3
{
    public class Resultado_Regresion_Lineal
    {
        public Resultado_Regresion_Lineal(bool resultado_correcto, string mensaje, double coeficioente, double a0, double a1)
        {
            Ok = resultado_correcto;
            Mensaje = mensaje;
            Coeficiente = coeficioente;
            A0 = a0;
            A1 = a1;
        }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public double Coeficiente { get; set; }
        public double A0 { get; set; }
        public double A1 { get; set; }
    }
}
