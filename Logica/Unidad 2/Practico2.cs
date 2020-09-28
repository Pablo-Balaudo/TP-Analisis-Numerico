using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.Unidad_2
{
    public class Practico2
    {

        // -------------------------------------------------Gauss Jordan-------------------------------------------------------

        public static Resultado_TP2 GaussJordan(double[,] matriz, int dim)
        {
            Resultado_TP2 result = new Resultado_TP2(true, "", dim, 0);
            double[] r = new double[dim];

            for (int i = 0; i < dim; i++)
            {
                double coef = matriz[i, i];
                for (int j = 0; j < dim + 1; j++)
                {
                    matriz[i, j] = matriz[i, j] / coef;
                }
                for (int j = 0; j < dim; j++)
                {
                    if (i != j)
                    {
                        coef = matriz[j, i];
                        for (int k = 0; k < dim + 1; k++)
                        {
                            matriz[j, k] = matriz[j, k] - (coef * matriz[i, k]);
                        }
                    }
                }
            }
            for (int i = 0; i < dim; i++)
            {
                r[i] = matriz[i, dim];
            }
            result.Resoluciones = r;
            return result;
        }

        // -------------------------------------------------Gauss Seidel-------------------------------------------------------
        public static Resultado_TP2 GaussSeidel(double[,] matriz, int dim, int iter, double tole)
        {
            Resultado_TP2 result = new Resultado_TP2(true, "", dim, 0);

            double[] s_iterado = new double[dim]; // seteo el vector S en 0
            for (int x = 0; x < dim; x++)
            {
                s_iterado[x] = 0;
            }

            double sumatoria = 0;
            double valor_diagonal = 0;
            bool b = false;
            int iteraciones = 0;
            double[] s_anterior = new double[dim];

            while(iteraciones < iter)
            {
                for (int i = 0; i<dim; i++)
                {
                    s_anterior[i] = s_iterado[i];
                }
                
                for (int i = 0; i < dim; i++) //se despejan las incognitas
                {
                    sumatoria = 0;
                    valor_diagonal = 0;
                    for (int j = 0; j < dim; j++)
                    {
                        if (j == i) //si esta en la diagonal, guardamos el valor para despues usarlo para dividir
                        {
                            valor_diagonal = matriz[i, j];
                        }
                        else  //si no es la diagonal, sumamos su valor (en la primera iteración van a ser todos 0)
                        {
                            sumatoria += matriz[i, j] * s_iterado[j];
                        }
                    }
                    s_iterado[i] = (matriz[i, dim] - sumatoria) / valor_diagonal;
                    
                } 
                iteraciones += 1;
                int cont = 0;

                //Evaluamos Tolerancia
                for (int x = 0; x < dim; x++)
                {
                    if (Math.Abs(s_iterado[x] - s_anterior[x]) < tole)
                    {
                        cont += 1;
                    }
                }
                if (cont == dim)  
                { 
                    for (int x = 0; x < dim; x++)
                    {
                        result.Resoluciones[x] = s_iterado[x];
                    }
                    return result;
                }

            }
            result.Mensaje = "Cantidad de iteraciones excedida, no se llego a una resolución";
            result.Ok = false;
            return result;
        }
    }





}
