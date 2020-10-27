using System;
using System.Collections.Generic;
using System.Text;
using Calculus;

namespace Logica.Unidad_4
{
    class Practico4
    {
        public static double Fx(string func, double x)
        {
            double f = 0;
            Calculo funcion = new Calculo();
            if (funcion.Sintaxis(func, 'x'))
                f = funcion.EvaluaFx(x);
            return f;
        }

        private static Resultado_TP4 ChequearFuncion(string func)
        {
            Resultado_TP4 nuevo = new Resultado_TP4(true,"El area es: ");
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(func, 'x'))
            {
                nuevo.Ok = false;
                nuevo.Mensaje = "La función no es admitida";
            }
            return nuevo;
        }

        public static Resultado_TP4 CalcularTrapecioSimple(string funcion, double a, double b)
        {
            Resultado_TP4 result = ChequearFuncion(funcion);
            if (result.Ok)        
            {
                result.Resolucion = ((Fx(funcion, a) + Fx(funcion, b)) * (b - a)) / 2;
            }
            return result;
        }

        public Resultado_TP4 CalcularTrapecioMultiple(double a, double b, string funcion, int n)
        {
            Resultado_TP4 result = ChequearFuncion(funcion);
            if (!result.Ok)
            {
                return result;
            }
            double h = (b - a) / n;
            double Sum = 0;
            for (int i = 1; i<=n - 1; i++)
            {
                Sum += Fx(funcion, a + (i * h));
            }
            result.Resolucion = (h / 2) * (Fx(funcion, a) + (2 * Sum) + Fx(funcion, b));
            return result
        }

        public static Resultado_TP4 CalcularSimpsonUnTercioSimple(string funcion, double a, double b)
        {
            Resultado_TP4 nuevo = ChequearFuncion(funcion);
            if (nuevo.Ok)
            {
                double h = (b - a) / 2;
                nuevo.Resolucion = (h / 3) * (Fx(funcion, a) + (4 * Fx(funcion, (a + h))) + Fx(funcion, b));
            }
            return nuevo;
        }

    }
}
