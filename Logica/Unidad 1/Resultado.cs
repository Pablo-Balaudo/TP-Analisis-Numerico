namespace Logica.Unidad_1
{
    public class Resultado
    {
        public int Iteraciones { get; set; }
        public double Tolerancia { get; set; }
        public double Resolucion { get; set; }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }


        public Resultado(int iteraciones, double tolerancia, double resolucion, bool band, string mensaje)
        {
            Iteraciones = iteraciones;
            Tolerancia = tolerancia;
            Resolucion = resolucion;
            Ok = band;
            Mensaje = mensaje;
        }

        public Resultado()
        {
        }
    }
}
