using Logica.Unidad_2;
using System;

namespace Logica.Unidad_3
{
    public class Unidad3
    {
        public static double[,] RegresionPolinomial(double[] VectorX, double[] VectorY, int n, int Grado)
        {
            double sum_x = 0, sum_y = 0;
            double[,] Matriz = new double[Grado, Grado + 1];
            for (int i = 0; i < n; i++)
            {
                sum_x += VectorX[i];
                sum_y += VectorY[i];
                for (int j = 0; j < Grado; j++)
                {
                    for (int k = 0; k < Grado; k++)
                    {
                        Matriz[j, k] += Math.Pow(VectorX[i], (k + j));
                    }
                    Matriz[j, Grado] += VectorY[i] * (Math.Pow(VectorX[i], j));
                }
            }
            return Matriz;
        }
        public static Resultado_TP2 RegresionLineal(double[] vector_x, double[] vector_y, int n, int Grado, int max_grado)
        {
            //Obtengo el sistema de ecuaciones
            double[,] auxiliar = Logica.Unidad_3.Unidad3.RegresionPolinomial(vector_x, vector_y, n, Grado);

            //Obtengo los valores del sistema de ecuaciones
            Logica.Unidad_2.Resultado_TP2 res = Practico2.GaussJordan(auxiliar, Grado);
            if (res.Ok != false)
            {
                //Calcular sr y st para poder calcular el coeficiente de correlación
                double sum_y = 0, sr = 0, st = 0, sr_temp;
                for (int i = 0; i < n; i++)
                { sum_y += vector_y[i]; }
                for (int i = 0; i < n; i++)
                {
                    sr_temp = vector_y[i] - res.Resoluciones[0];
                    for (int j = max_grado; j > 0; j--)
                    {
                        sr_temp -= Grado - 1 >= j ? Math.Pow(vector_x[i], j) * res.Resoluciones[j] : 0;
                    }
                    sr += Math.Pow(sr_temp, 2);
                    st += Math.Pow(vector_y[i] - (sum_y / n), 2);
                }

                //Evaluar coeficiente de correlación
                res.Coeficiente = ((st - sr) / st) * 100;
            }
            else
            { res.Coeficiente = -1; }
            return res;
        }
        
    }
}
