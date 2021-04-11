using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        private static string ValidarOperador(char operador)
        {
            string resultado = "+";

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return Convert.ToString(operador);
            }
            return  resultado;
        }


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
