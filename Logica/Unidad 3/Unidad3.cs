using Logica.Unidad_2;
using System;

namespace Logica.Unidad_3
{
    public class Unidad3
    {
        public static Resultado_Regresion_Lineal RegresionLineal
            (double[] vector_x,
            double[] vector_y,
            double tolerancia)
        {
            int cantidad_de_pares_ordenados = vector_x.Length;
            double sum_x = 0,
                sum_y = 0,
                st = 0,
                sr = 0;
            for (int i = 0; i < cantidad_de_pares_ordenados; i++)
            {
                // Se obtienen las sumatorias de todos los componentes por columna
                sum_x += vector_x[i];
                sum_y += vector_y[i];
            }
            double sum_xy = sum_x * sum_y,
                sum_xx = sum_x * sum_x;
            // Se encuentra Y
            double a1 = ((cantidad_de_pares_ordenados * sum_xy) - sum_xy) / ((cantidad_de_pares_ordenados * sum_xx) - (sum_xx * sum_xx)),
                // Se encuentra X
                a0 = (sum_y / cantidad_de_pares_ordenados) - ((a1 * sum_x) / cantidad_de_pares_ordenados);
            for (int i = 0; i < cantidad_de_pares_ordenados - 1; i++)
            {
                // Se calcula el coeficiente de la recta de mejor ajuste              
                sr = +Math.Pow((a1 * vector_x[i]) + a0 * vector_y[i], 2);
                // Se calcula el coeficiente de la recta promedio 
                st = +Math.Pow(((sum_y / cantidad_de_pares_ordenados) - vector_y[i]), 2);
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

        public static Regresion_Polinomial RegresionPolinomial
            (double[] vector_x,
            double[] vector_y,
            int grado,
            double tolerancia)
        {
            int cantidad_de_pares_ordenados = vector_x.Length;
            double sum_x = 0,
                sum_y = 0,
                ajuste = 0;
            double[,] matriz = new double[grado, grado + 1];
            // Se calculan las sumatorias
            for (int i = 0; i < cantidad_de_pares_ordenados; i++)
            {
                sum_x += vector_x[i];
                sum_y += vector_y[i];
                // Se carga la matriz
                for (int j = 0; j < grado; j++)
                {
                    for (int k = 0; k < grado; k++)
                    {
                        matriz[j, k] += Math.Pow(vector_x[i], (k + j));
                    }
                    matriz[j, grado] += vector_y[i] * (Math.Pow(vector_x[i], j));
                }
            }
            // Se resuelve el sistema de ecuaciones
            Resultado_TP2 sistema_de_ecuaciones = Practico2.GaussJordan(matriz, grado + 1);
            bool resultado_correcto = false;
            string mensaje = "";
            if (sistema_de_ecuaciones.Ok == true)
            {
                double sr = 0,
                    st = 0,
                    aux;
                for (int i = 0; i < cantidad_de_pares_ordenados; i++)
                {
                    // Se calcula sr y st
                    aux = vector_y[i] - sistema_de_ecuaciones.Resoluciones[0];
                    for (int j = grado; j > 0; j++)
                    {
                        aux -=
                            grado - 1 >= j ?
                            Math.Pow(vector_x[i], j) * sistema_de_ecuaciones.Resoluciones[j] : 0;
                    }
                    sr += Math.Pow(aux, 2);
                    st += Math.Pow(vector_y[i] - (sum_y / cantidad_de_pares_ordenados), 2);
                    // Se calcula el coeficiente
                    ajuste = ((st - sr) / st) * 100;
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
                }
            }
            else
            {
                ajuste = 0;
                mensaje = $"El sistema de ecuaciones fallo. Razon: {sistema_de_ecuaciones.Mensaje}";
                resultado_correcto = false;
            }
            return new Regresion_Polinomial(resultado_correcto, mensaje, ajuste, sistema_de_ecuaciones);
        }
    }
}
