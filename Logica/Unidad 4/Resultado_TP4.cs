namespace Logica.Unidad_4
{
    public class Resultado_TP4
    {
        public Resultado_TP4(bool ok, string m)
        {
            Mensaje = m;
            Ok = ok;
        }

        public string Mensaje { get; set; }
        public double Resolucion { get; set; }
        public bool Ok { get; set; }
    }
}
