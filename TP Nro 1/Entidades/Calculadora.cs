using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Calculadora
    {


        /// <summary>
        /// Valida que el elemento recibido sera un operador "+, -, * o /"
        /// </summary>
        /// <param name="operador">El operador recibido en formato char</param>
        /// <returns>El operador en formato string. Si el parametro es erroneo devuelve "+"</returns>
        private static string ValidarOperador(char operador)
        {
            string resultado = "+";

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return Convert.ToString(operador);
            }
            return resultado;
        }


        /// <summary>
        /// Valida y realiza la operacion pedida entre dos objetos de tipo Numero
        /// </summary>
        /// <param name="num1">Objeto de tipo numero</param>
        /// <param name="num2">Objeto de tipo numero</param>
        /// <param name="operador">Operador en formato string</param>
        /// <returns>El resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            switch (ValidarOperador(Convert.ToChar(operador)))
            {
                case "+":
                    resultado = (num1 + num2);
                    break;
                case "-":
                    resultado = (num1 - num2);
                    break;
                case "*":
                    resultado = (num1 * num2);
                    break;
                case "/":
                    resultado = (num1 / num2);
                    break;
            }
            return resultado;
        }

    }
}
