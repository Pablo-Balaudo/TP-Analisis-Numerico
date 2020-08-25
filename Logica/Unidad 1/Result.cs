using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.Unidad_1
{
    public class Result
    {
        public int Iter { get; set; }
        public decimal Tole { get; set; }
        public double Resolucion { get; set; }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }


        public Result(int i, decimal tol, double sol, bool band, string mensaje)
        {
            Iter = i;
            Tole = tol;
            Resolucion = sol;
            Ok = band;
            Mensaje = mensaje;
        }

        public Result()
        {
        }
    }
}
