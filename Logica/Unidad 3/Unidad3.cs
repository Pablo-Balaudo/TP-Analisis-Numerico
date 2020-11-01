using System;

namespace Logica.Unidad_3
{
    public class Unidad3
    {
        public static Resultado_Regresion_Lineal RegresionLineal
            (double[] vector_x, double[] vector_y, double tolerancia, int n)
        {
            double sum_x = 0;
            double sum_y = 0;
            double st = 0;
            double sr = 0;
            for (int i = 0; i < n; i++)
            {
                // Se obtienen las sumatorias de todos los componentes por columna
                sum_x += vector_x[i];
                sum_y += vector_y[i];
            }
            double sum_xy = sum_x * sum_y;
            double sum_xx = sum_x * sum_x;
            // Se encuentra Y
            double a1 = ((n * sum_xy) - sum_xy) / ((n * sum_xx) - (sum_xx * sum_xx));
            // Se encuentra X
            double a0 = (sum_y / n) - ((a1 * sum_x) / n);
            for (int i = 0; i < n - 1; i++)
            {
                // Se calcula el coeficiente de la recta de mejor ajuste              
                sr = +Math.Pow((a1 * vector_x[i]) + a0 * vector_y[i], 2);
                // Se calcula rl coeficiente de la recta promedio 
                st = +Math.Pow(((sum_y / n) - vector_y[i]), 2);
            }
            double ajuste = Math.Sqrt((st - sr) / st) * 100;
            bool resultado_correcto;
            string mensaje;
            // Si el ajuste no es aceptable
            if (ajuste < tolerancia)
            {
                resultado_correcto = false;
                mensaje = $"El ajuste no es aceptable ya que es menor a {tolerancia}";
            }
            // Si el ajuste es aceptable
            else
            {
                resultado_correcto = true;
                mensaje = $"El ajuste es aceptable ya que es mayor o igual a {tolerancia}";
            }
            return new Resultado_Regresion_Lineal(resultado_correcto, mensaje, ajuste, a0, a1);
        }

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
