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
        public static Resultado_TP2 RegresionPorMC(double[] vector_x, double[] vector_y, int n, int Grado, int max_grado)
        {
            //Obtengo el sistema de ecuaciones
            double[,] auxiliar = RegresionPolinomial(vector_x, vector_y, n, Grado);
            Resultado_TP2 res = Practico2.GaussJordan(auxiliar, Grado);
            if (res.Ok != false)
            {

                //Calcular sr y st para poder calcular el coeficiente de correlación
                double sum_y = 0, sr = 0, st = 0, sr_temp;
                for (int i = 0; i < n; i++)
                { 
                    sum_y += vector_y[i]; 
                }
                double media_y = sum_y / n;
                if (Grado == 2)
                {
                    double sum_xx = 0;
                    double sum_x = 0;
                    double sum_xy = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum_xx += Math.Pow(vector_x[i],2);
                        sum_x += vector_x[i];
                        sum_xy += vector_x[i] * vector_y[i];
                    }

                    double a1 = (n * sum_xy - sum_x * sum_y) / (n * sum_xx - Math.Pow(sum_x, 2));
                    double a0 = (sum_y/n)-(a1*(sum_x/n));
                    for (int i = 0; i < n - 1; i++)
                    {
                        // Se calcula el coeficiente de la recta de mejor ajuste      
                        sr += Math.Pow((a1 * vector_x[i] + a0 - vector_y[i]), 2);
                        // Se calcula rl coeficiente de la recta promedio 
                        st += Math.Pow((media_y - vector_y[i]), 2);
                    }
                }
                else 
                {
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
