using System;
using System.Collections.Generic;
using System.Text;
using Calculus;
namespace Logica.Unidad_1
{
    public class Ejercicio1 : Entrada
    {        

        public static Resultado Analizador(string funcion)
        {
            Resultado nuevo = new Resultado(0, 0, 0, true, "");

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

            if (operacion == 0)
            {
                if (Fx(funcion, x_izquierda) == 0)
                    resultado.Resolucion = x_izquierda;
                else
                    resultado.Resolucion = x_derecha;
                return resultado;
            }
            else
            {
                if (operacion > 0)
                {
                    resultado.Ok = false;
                    resultado.Mensaje = "Limite Derecho o Izquierdo incorrectos, por favor ingreselos nuevamente";
                    return resultado;
                }
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
                    return new Resultado(intentos, resultado.Tolerancia, x_resultado, true, "");
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

        public static Resultado ReglaFalsa(string funcion, double iteraciones, double tolerancia, double x_izquierda, double x_derecha)
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
            
            if (operacion == 0)
            {
                if (Fx(funcion, x_izquierda) == 0)
                    resultado.Resolucion = x_izquierda;
                else
                    resultado.Resolucion = x_derecha;
                return resultado;

            }
            else
            {
                if (operacion > 0)
                {
                    resultado.Ok = false;
                    resultado.Mensaje = "Limite Derecho o Izquierdo incorrectos, por favor ingreselos nuevamente";
                    return resultado;
                }
            }
            
            while (true)
            {
                intentos++;
                double x_resultado = ((-(Fx(funcion, x_derecha)) * x_izquierda) + (Fx(funcion, x_izquierda) * x_derecha)) / (Fx(funcion, x_izquierda) - Fx(funcion, x_derecha));
                double error = (x_izquierda + x_derecha == 0) ? 1 : CalcularError(x_resultado, x_ant);
                if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                {
                    if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia)
                        resultado.Tolerancia = Math.Abs(Fx(funcion, x_resultado));
                    else
                        resultado.Tolerancia = error;
                    Resultado resultx = new Resultado(intentos, resultado.Tolerancia, x_resultado, true, "");
                    return resultx;
                }
                else
                {
                    if (Fx(funcion, x_izquierda) * Fx(funcion, x_resultado) > 0)
                    { x_izquierda = x_resultado; }
                    else
                    { x_derecha = x_resultado; }
                    x_ant = x_resultado;
                }
            }
        }

        public static Resultado Newton(string funcion, double iteraciones, double tolerancia, double x_inicial)
        {
            Resultado resultado = Analizador(funcion);
            if (!resultado.Ok)
            {
                resultado.Mensaje = "No se pudo analizar la función";
                return resultado;
            }

            int intentos = 0;
            double x_ant = 0;
            double operacion = Fx(funcion, x_inicial);
            double x_resultado = x_inicial;
            double error = 1;
            if (operacion == 0)
            {
                resultado.Resolucion = x_inicial;         
                return resultado;
            }
            else
            {
                while ((Math.Abs(Fx(funcion, x_resultado)) >= tolerancia || Math.Abs(Fx(funcion, x_resultado)) == 0) && intentos < iteraciones && error > tolerancia)
                {
                    intentos++;
                    x_resultado -= (Fx(funcion, x_resultado) / ((Fx(funcion, x_resultado + tolerancia) - Fx(funcion, x_resultado)) / tolerancia));
                    error = (x_resultado == 0) ? 1 : CalcularError(x_resultado, x_ant);
                    if (double.IsInfinity(x_resultado) || double.IsNaN(x_resultado) || double.IsNaN(Fx(funcion, x_resultado)) || double.IsInfinity(Fx(funcion, x_resultado)))
                    {
                        resultado.Ok = false;
                        resultado.Mensaje = "El método no converge";
                        return resultado;
                    }
                    if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia | error < tolerancia | intentos >= iteraciones)
                    {
                        resultado.Resolucion = x_resultado;
                        resultado.Iteraciones = intentos;
                        if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia)
                            resultado.Tolerancia = Math.Abs(Fx(funcion, x_resultado));
                        else
                            resultado.Tolerancia = error;
                        return resultado;                    
                    }
                    else
                    {
                        x_ant = x_resultado;
                    }
                }
            }
            return resultado;
        }

        public static Resultado Secante(string funcion, double iteraciones, double tolerancia, double x_izquierda, double x_derecha)
        {
            Resultado result = Analizador(funcion);
            if (!result.Ok)
            {
                result.Mensaje = "No se pudo analizar la función";
                return result;
            }

            double oper = Fx(funcion, x_izquierda) * Fx(funcion, x_derecha);
            if (oper == 0)
            {
                if (Fx(funcion, x_izquierda) == 0)
                {
                    result.Resolucion = x_izquierda;
                }
                else
                {
                    result.Resolucion = x_derecha;
                }
                return result;
            }
            int intentos = 0;
            double x_ant = 0;
            double x_resultado = ((Fx(funcion, x_izquierda) * x_derecha - Fx(funcion, x_derecha) * x_izquierda) / (-Fx(funcion, x_derecha) + Fx(funcion, x_izquierda)));
            if (double.IsInfinity(x_resultado) || double.IsNaN(x_resultado) || double.IsNaN(Fx(funcion, x_resultado)) || double.IsInfinity(Fx(funcion, x_resultado)))
            {
                result.Ok = false;
                result.Mensaje = "El método no converge";
                return result;
            }
            while (intentos < iteraciones)
            {
                intentos++;
                x_resultado = ((Fx(funcion, x_izquierda) * x_derecha - Fx(funcion, x_derecha) * x_izquierda) / (-Fx(funcion, x_derecha) + Fx(funcion, x_izquierda)));
                if (double.IsInfinity(x_resultado) || double.IsNaN(x_resultado) || double.IsNaN(Fx(funcion, x_resultado)) || double.IsInfinity(Fx(funcion, x_resultado)))
                {
                    result.Ok = false;
                    result.Mensaje = "El método no converge";
                    return result;
                }
                else
                {
                    double error;
                    if ((x_izquierda + x_derecha) == 0)
                    {
                        error = 1;
                    }
                    else
                    {
                        error = CalcularError(x_resultado, x_ant);
                    }
                    //error = (x_izquierda + x_derecha == 0) ? 1 : CalcularError(x_izquierda, x_ant);
                    if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia || error < tolerancia || intentos > iteraciones)
                    {
                        result.Resolucion = x_resultado;
                        result.Iteraciones = intentos;
                        if (Math.Abs(Fx(funcion, x_resultado)) < tolerancia)
                            result.Tolerancia = Math.Abs(Fx(funcion, x_resultado));
                        else
                            result.Tolerancia = error;
                        return result;
                    }
                    else
                    {
                        if (Fx(funcion, x_izquierda) * Fx(funcion, x_resultado) < 0)
                        { x_derecha = x_resultado; }
                        else
                        { x_izquierda = x_resultado; }
                        x_ant = x_resultado;
                    }
                }
            }
            result.Ok = false;
            result.Mensaje = "El método no converge.";
            return result;
        }

     
    }
}
