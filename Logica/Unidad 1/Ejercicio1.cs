using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica.Unidad_1
{
    class Ejercicio1
    {
        string Funcion(string funcion, int iteraciones, int tolerancia, int numero1, int numero2)
        {
            switch (MismoSigno(numero1, numero2))
            {
                case "Mismo signo":
                    return Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString();
                case "Distinto signo": 
                    return ("Volver a ingresar los intervalos");                   
                default:
                    return ("La raiz es " + MismoSigno(numero1, numero2));
            }
            //return (MismoSigno(numero1, numero2)) switch
            //{
            //    "Mismo signo" => Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString(),
            //    "Distinto signo" => ("Volver a ingresar los intervalos"),
            //    _ => ("La raiz es " + MismoSigno(numero1, numero2)),
            //};
        }

        int Biseccion(string funcion, int iteraciones, int tolerancia, int numero1, int numero2)
        {
            int NoMeAcuerdoQueEra_XANT = 0;
            int intentos = 0;
            while (true)
            {
                intentos++;
                int mitad = (numero1 + numero2) / 2;
                int error = Math.Abs(mitad - NoMeAcuerdoQueEra_XANT / mitad);
                if (FormatearFuncion(funcion, mitad) < tolerancia || error < tolerancia || intentos >= iteraciones)
                {
                    return mitad;
                }
                else
                {
                    if (FormatearFuncion(funcion, numero1) * FormatearFuncion(funcion, numero2) > 0)
                    {
                        numero1 = mitad;
                    }
                    else
                    {
                        numero2 = mitad;
                    }
                    NoMeAcuerdoQueEra_XANT = mitad;
                }
            }         
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
