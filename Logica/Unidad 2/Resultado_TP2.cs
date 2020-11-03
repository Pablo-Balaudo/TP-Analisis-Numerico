namespace Logica.Unidad_2
{
    public class Resultado_TP2
    {
        public Resultado_TP2()
        {
            Resoluciones = new double[2];
        }

        public Resultado_TP2(bool b, string s, int inc, int iter)
        {
            Ok = b;
            Mensaje = s;
            Resoluciones = new double[inc];
            Iteraciones = iter;
            Coeficiente = 0;
        }
        public int Iteraciones { get; set; }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public double[] Resoluciones { get; set; }
        public double Coeficiente { get; set; }
    }
}
