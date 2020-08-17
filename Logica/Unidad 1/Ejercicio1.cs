using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica.Unidad_1
{
    class Ejercicio1
    {
        string Funcion(string funcion, int iteraciones, int tolerancia, int numero1, int numero2)
        //{
        //    return (MismoSigno(numero1, numero2)) switch
        //    {
        //        "Mismo signo" => Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString(),
        //        "Distinto signo" => ("Volver a ingresar los intervalos"),
        //        _ => ("La raiz es " + MismoSigno(numero1, numero2)),
        //    };
        //}

        int Biseccion(string funcion, int iteraciones, int tolerancia, int numero1, int numero2)
        {
            while (true)
            {

            }

            return 1;
        }

        /// <summary>
        /// Devuelve 3 posibles strings, "Mismo signo", "Distinto signo", o la raiz en string 
        /// </summary>
        string MismoSigno(int numero1, int numero2)
        {
            if (numero1 * numero2 > 0)
            {
                return "Mismo signo";
            }
            else
            {
                if (numero1 * numero2 < 0)
                {
                    return "Distinto signo";
                }
                else
                {
                    if (numero1 == 0)
                    {
                        return numero1.ToString();
                    }
                    else
                    {
                        return numero2.ToString();
                    }
                }
            }
        }

        int FormatearFuncion(string funcion, int numero)
        {
            {
                string FuncionLimpia = funcion.Trim();
                FuncionLimpia = FuncionLimpia.Replace("X", numero.ToString());
                DataTable ResultadoNumero = new DataTable();
                return (int)ResultadoNumero.Compute(FuncionLimpia, "");
            }
        }
    }
}
