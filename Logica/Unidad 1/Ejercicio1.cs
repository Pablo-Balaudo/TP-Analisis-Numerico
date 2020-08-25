using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Calculus;
namespace Logica.Unidad_1
{
    public class Ejercicio1 : Entrada
    {
        //public string Funcion(string funcion, double iteraciones, double tolerancia, double numero1, double numero2)
        //{
        //    switch (MismoSigno(FormatearFuncion(funcion, numero1), FormatearFuncion(funcion,numero2)))
        //    {
        //        case "Mismo signo":
        //            return ("Volver a ingresar los intervalos");
        //        case "Distinto signo":
        //            return Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString();
        //        default:
        //            return ("La raiz es " + MismoSigno(FormatearFuncion(funcion, numero1), FormatearFuncion(funcion, numero2)));
        //    }
        //    return (MismoSigno(numero1, numero2)) switch
        //    {
        //        "Mismo signo" => Biseccion(funcion, iteraciones, tolerancia, numero1, numero2).ToString(),
        //        "Distinto signo" => ("Volver a ingresar los intervalos"),
        //        _ => ("La raiz es " + MismoSigno(numero1, numero2)),
        //    };
        //}
        public static Result Analizador(string funcion)
        {
            Result nuevo = new Result(0, 0, 0, true, "");
            double fx;
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(funcion, 'x'))
            {
                nuevo.Ok = false;
                nuevo.Mensaje = "Expresion no valida";
            }
            return nuevo;
        }

        public static float Fx(string func, double x)
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

        public static Result Biseccion(string funcion, double iteraciones, double tolerancia, float x_izq, float x_der)
        {
            Result resultado = Analizador(funcion);
            if (!resultado.Ok)
            {
                resultado.Mensaje = "No se pudo analizar la función";
                return resultado;
            }

            int intentos = 0;
            float x_ant = 0;
            double operacion = Fx(funcion, x_izq) * Fx(funcion, x_der);

            if (operacion > 0)
            {
                if (operacion == 0)
                {
                    if (Fx(funcion, x_izq) == 0)
                        resultado.Resolucion = x_izq;

                    else
                        resultado.Resolucion = x_der;
                }
                else
                {
                    resultado.Ok = false;
                    resultado.Mensaje = "Limite Derecho o Izquierdo incorrectos, por favor ingreselos nuevamente";
                }
                return resultado;
            }

            while (true)
            {
                intentos++;
                float xr = (x_izq + x_der) / 2;
                float error = (x_izq + x_der == 0) ? 1 : CalcularError(xr, x_ant);
                if (Math.Abs(Fx(funcion, xr)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                {                   
                    
                    if (Math.Abs(Fx(funcion, xr)) < tolerancia)
                        resultado.Tole = Convert.ToDecimal(Math.Abs(Fx(funcion, xr)));
                    else
                        resultado.Tole = Convert.ToDecimal(error);
                    Result resultx = new Result(intentos, resultado.Tole, xr, true, "");
                    return resultx;
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
