using System;
using System.Collections.Generic;
//using System.Data;
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
        public static Resultado Analizador(string funcion)
        {
            Resultado nuevo = new Resultado(0, 0, 0, true, "");
            double fx; //SIRVE DE ALGO?
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(funcion, 'x'))
            {
                nuevo.Ok = false;
                nuevo.Mensaje = "Expresion no valida";
            }
            return nuevo;
        }

        public static double Fx(string func, double x)
        {
            double f = 0;
            Calculo funcion = new Calculo();
            if (funcion.Sintaxis(func, 'x'))
                f = funcion.EvaluaFx(x);
            return f;
        }

        static double CalcularError(double xr, double xant)
        {            
            return Math.Abs((xr - xant) / xr);            
        }
        

        public static Resultado Biseccion(string funcion, double iteraciones, double tolerancia, double x_izquierda, double x_derecha)
        {
            Resultado resultado = Analizador(funcion);
            if (!resultado.Ok)
            {
                resultado.Mensaje = "No se pudo analizar la función";
                return resultado;
            }

            int intentos = 0;
            double x_ant = 0;
            double operacion = Fx(funcion, x_izquierda) * Fx(funcion, x_derecha);

            if (operacion > 0) //No quedaria mejor If (operacion < 0) {resultado.ok = falso, etc}; else {if (op == 0)}
            {
                if (operacion == 0)
                {
                    if (Fx(funcion, x_izquierda) == 0)
                        resultado.Resolucion = x_izquierda;

                    else
                        resultado.Resolucion = x_derecha;
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
                double x_resultado = (x_izquierda + x_derecha) / 2;
                double error = (x_izquierda + x_derecha == 0) ? 1 : CalcularError(x_resultado, x_ant);
                if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                {

                    if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia)
                        resultado.Tolerancia = Math.Abs(Fx(funcion, x_resultado));
                        //resultado.Tolerancia = Convert.ToDecimal(Math.Abs(Fx(funcion, x_resultado)));
                    else
                        resultado.Tolerancia = error;
                        //resultado.Tolerancia = Convert.ToDecimal(error);
                    Resultado resultx = new Resultado(intentos, resultado.Tolerancia, x_resultado, true, "");
                    return resultx;
                }
                else
                {
                    if (Fx(funcion, x_izquierda) * Fx(funcion, x_resultado) > 0)
                    {
                        x_izquierda = x_resultado;
                    }
                    else
                    {
                        x_derecha = x_resultado;
                    }
                    x_ant = x_resultado;
                }
            }
        }
        
        public static Resultado Newton(string funcion, string funcion_derivada, double iteraciones, double tolerancia, double x_inicial)
        {
            Resultado resultado = Analizador(funcion);
            if (!resultado.Ok)
            {
                resultado.Mensaje = "No se pudo analizar la función";
                return resultado;
            }

            Resultado resultado_deivada = Analizador(funcion_derivada);
            if (!resultado_deivada.Ok)
            {
                resultado_deivada.Mensaje = "No se pudo analizar la función";
                return resultado_deivada;
            }

            int intentos = 0;
            double x_ant = 0;
            double operacion = Fx(funcion, x_inicial);

            if (operacion < tolerancia)
            {
                resultado.Resolucion = x_inicial;
            }
            else
            {
                while (true)
                {
                    intentos++;
                    double x_resultado = x_inicial - operacion / Fx(funcion_derivada, x_inicial);
                    double error = CalcularError(x_resultado, x_ant);
                    if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                    {
                        return new Resultado(intentos, tolerancia, x_resultado, true, "");                        
                    }
                    else
                    {                                               
                        x_inicial = x_resultado;                                                
                        x_ant = x_resultado;                        
                    }
                }
            }
            return resultado;            

            
        }


            

        /// <summary>
        /// Devuelve 3 posibles strings, "Mismo signo", "Distinto signo", o la raiz en string 
        /// </summary>
        //string MismoSigno(double numero1, double numero2)
        //{
        //    if (numero1 * numero2 > 0)
        //    {
        //        return "Mismo signo";
        //    }
        //    else
        //    {
        //        if (numero1 * numero2 < 0)
        //        {
        //            return "Distinto signo";
        //        }
        //        else
        //        {
        //            if (numero1 == 0)
        //            {
        //                return numero1.ToString();
        //            }
        //            else
        //            {
        //                return numero2.ToString();
        //            }
        //        }
        //    }
        //}

        //double FormatearFuncion(string funcion, double numero)
        //{
        //    {           
        //        string FuncionLimpia = funcion.Trim();
        //        FuncionLimpia = FuncionLimpia.Replace("X", numero.ToString());
        //        DataTable ResultadoNumero = new DataTable();
        //        //Reemplazar DataTable por https://github.com/ncalc/ncalc
        //        return double.Parse(ResultadoNumero.Compute(FuncionLimpia, "").ToString());
        //    }
        //}
        

    }
}
