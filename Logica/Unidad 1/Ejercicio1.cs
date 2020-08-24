using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica.Unidad_1
{
    public class Ejercicio1
    {
        public string Funcion(string funcion, double iteraciones, double tolerancia, double numero1, double numero2)
        {
            switch (MismoSigno(FormatearFuncion(funcion, numero1), FormatearFuncion(funcion,numero2)))
            {
                case "Mismo signo":
                    return ("Volver a ingresar los intervalos");
                case "Distinto signo":
                    return Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString();
                default:
                    return ("La raiz es " + MismoSigno(FormatearFuncion(funcion, numero1), FormatearFuncion(funcion, numero2)));
            }
            //return (MismoSigno(numero1, numero2)) switch
            //{
            //    "Mismo signo" => Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString(),
            //    "Distinto signo" => ("Volver a ingresar los intervalos"),
            //    _ => ("La raiz es " + MismoSigno(numero1, numero2)),
            //};
        }

        public Result Biseccion(string funcion, double iteraciones, double tolerancia, double numero1, double numero2)
        {
            double NoMeAcuerdoQueEra_XANT = 0;
            
            double intentos = 0;
            while (true)
            {
                intentos++;
                double mitad = (numero1 + numero2) / 2;
                double error = Math.Abs((mitad - NoMeAcuerdoQueEra_XANT) / mitad);
                if (Math.Abs(FormatearFuncion(funcion, mitad)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                {
                    Result resultado = new Result(intentos, tolerancia, mitad, true, "");
                    return resultado;
                }
                else
                {
                    if (FormatearFuncion(funcion, numero1) * FormatearFuncion(funcion, mitad) > 0)
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
        string MismoSigno(double numero1, double numero2)
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

        double FormatearFuncion(string funcion, double numero)
        {
            {
                string FuncionLimpia = funcion.Trim();
                FuncionLimpia = FuncionLimpia.Replace("X", numero.ToString());
                DataTable ResultadoNumero = new DataTable();
                //Reemplazar DataTable por https://github.com/ncalc/ncalc
                return double.Parse(ResultadoNumero.Compute(FuncionLimpia, "").ToString());
            }
        }
        

    }
}
