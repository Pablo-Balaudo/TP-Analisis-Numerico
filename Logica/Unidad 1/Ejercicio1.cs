using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Calculus;
namespace Logica.Unidad_1
{
    public class Ejercicio1 : Entrada
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
        static Result Analizador(string func)
        {
            Result nuevo = new Result(0, 0, 0, true, "");
            double fx;
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(func, 'x'))
            {
                nuevo.Ok = false;
                nuevo.Mensaje = "Expresion no valida";
            }
            return nuevo;
        }

        static float Fx(string func, double x)
        {
            double f = 0;
            Calculo funcion = new Calculo();
            if (funcion.Sintaxis(func, 'x'))
                f = funcion.EvaluaFx(x);
            return (float)f;
        }

        static float CalcularError(float xr, float xant)
        {
            return Math.Abs((xr - xant) / xr);
        }

        public Result Biseccion(string funcion, double iteraciones, double tolerancia, double x_izq, double x_der)
        {
            double x_ant = 0;
            Result resultado = Analizador(funcion);
            double intentos = 0;
            double error = 1;
            while (true)
            {
                intentos++;
                double xr = (x_izq + x_der) / 2;
                error = (x_izq+x_der == 0) ? 1 : Math.Abs((xr - x_ant) / xr);
                if (Math.Abs(Fx(funcion, xr)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                {
                    resultado = new Result(intentos, tolerancia, xr, true, "");
                    return resultado;
                }
                else
                {
                    if (Fx(funcion, x_izq) * Fx(funcion, xr) > 0)
                    {
                        x_izq = xr;
                    }
                    else
                    {
                        x_der = xr;
                    }
                    x_ant = xr;
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
