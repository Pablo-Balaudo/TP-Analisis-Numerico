using Logica.Unidad_2;

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

    public class Regresion_Polinomial
    {
        public Regresion_Polinomial(bool resultado_correcto, string mensaje, double coeficiente, Resultado_TP2 resultado_sistema_de_ecuaciones)
        {
            Resultado_Correcto = resultado_correcto;
            Mensaje = mensaje;
            Coeficiente = coeficiente;
            Resultado_Sistema_de_Ecuaciones = resultado_sistema_de_ecuaciones;
        }
        public bool Resultado_Correcto { get; set; }
        public double Coeficiente { get; set; }
        public string Mensaje { get; set; }
        /* 
         * Estado Ok, Mensaje y las Resoluciones del resultado del sistemas de ecuaciones
         * se obtienen de los atributos de Resultado_Sistema_de_Ecuaciones
         */
        public Resultado_TP2 Resultado_Sistema_de_Ecuaciones { get; set; }
    }
}
