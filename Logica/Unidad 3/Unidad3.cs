using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.Unidad_3
{
    public class Unidad3
    {
        public static double[,] RegresionPolinomial(double[] vector_x, double[] vector_y, int n, int grado)
        {
            double sum_x = 0, sum_y = 0;
            double[,] matriz = new double[grado, grado + 1];
            for (int i = 0; i < n; i++)
            {
                sum_x += vector_x[i];
                sum_y += vector_y[i];
                for (int j = 0; j < grado; j++)
                {
                    for (int k = 0; k < grado; k++)
                    {
                        matriz[j, k] += Math.Pow(vector_x[i], (k + j));
                    }
                    matriz[j, grado] += vector_y[i] * (Math.Pow(vector_x[i], j));
                }
            }
            return matriz;
        }
    }
}
