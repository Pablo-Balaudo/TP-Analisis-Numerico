using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.Unidad_2
{
    public class Practico2
    {

        public static double Realizar_Determinante(double[,] matriz, int inc)
        {
            double resol = 0;
            if (inc == 2)
            {
                return matriz[0, 0] * matriz[1, 1] - matriz[1, 0] * matriz[0, 1];
            }
            else
            {
                _ = new double[inc - 1, inc - 1];
                for (int i = 0; i < inc; i++)
                {
                    double[,] aux = MatrizDeCofactores(matriz, inc, i);
                    resol += Math.Pow(-1, i) * matriz[0, i] * Realizar_Determinante(aux, inc - 1);
                }
                return resol;
            }
        }

        public static double[,] MatrizDeCofactores(double[,] matriz, int inc, int i)
        {
            double[,] matriz_aux = new double[inc - 1, inc - 1];
            int x = 0;
            int y = 0;
            for (int j = 0; j < inc; j++)
            {
                for (int k = 0; k < inc; k++)
                {
                    if (j != 0 && k != i)
                    {
                        matriz_aux[x, y] = matriz[j, k];
                        if (y < inc - 2)
                        { y += 1; }
                        else
                        { x += 1; y = 0; };
                    }
                }
            }
            return matriz_aux;
        }

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
            
            if (Realizar_Determinante(matriz, dim) == 0)
            {
                result.Mensaje = "El sistema no converge en una resolución";
                result.Ok = false;
                return result;
            }
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
