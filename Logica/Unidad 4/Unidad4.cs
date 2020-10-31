using System;
using System.Collections.Generic;
using System.Text;
using Calculus;

namespace Logica.Unidad_4
{
    public class Unidad4
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
            Resultado_TP4 result = new Resultado_TP4(true,"El area es: ");
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(func, 'x'))
            {
                result.Ok = false;
                result.Mensaje = "La función no es admitida";
            }
            return result;
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

        public static Resultado_TP4 CalcularTrapecioMultiple(double a, double b, string funcion, int n)
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
            return result;
        }

        public static Resultado_TP4 CalcularSimpsonUnTercioSimple(string funcion, double a, double b)
        {
            Resultado_TP4 result = ChequearFuncion(funcion);
            if (result.Ok)
            {
                double h = (b - a) / 2;
                result.Resolucion = (h / 3) * (Fx(funcion, a) + (4 * Fx(funcion, (a + h))) + Fx(funcion, b));
            }
            return result;
        }

        public static Resultado_TP4 CalcularSimpsonUnTercioMultiple(string funcion, double a, double b, int n)
        {
            Resultado_TP4 result = ChequearFuncion(funcion);
            if (result.Ok)
            {
                double h = (b - a) / n;
                double fx0 = Fx(funcion, a);
                double fxn = Fx(funcion, b);
                double sum_fximpares = 0; double sum_fxpares = 0; double xi = 0;

                for (int i = 1; i <= n - 1; i += 2) //Se suman los impares
                {
                    xi = a + (i * h);
                    sum_fximpares += Fx(funcion, xi);
                }

                for (int i = 2; i <= n - 2; i += 2) //Se suman los pares
                {
                    xi = a + (i * h);
                    sum_fxpares += Fx(funcion, xi);
                }

                result.Resolucion = (h / 3) * (fx0 + (4 * sum_fximpares) + (2 * sum_fxpares) + fxn);
            }
            return result;
        }

        public static Resultado_TP4 CalcularSimpsonTresOctavos(string funcion, double a, double b)
        {
            Resultado_TP4 result = ChequearFuncion(funcion);
            if (result.Ok)
            {
                double h = (b - a) / 3;
                double fx0 = Fx(funcion, a);
                double fx1 = Fx(funcion, (a + h));
                double fx2 = Fx(funcion, (a + (2 * h)));
                double fx3 = Fx(funcion, b);
                result.Resolucion = ((3 * h) / 8) * (fx0 + (3 * fx1) + (3 * fx2) + fx3);
            }
            return result;
        }


    }
}
