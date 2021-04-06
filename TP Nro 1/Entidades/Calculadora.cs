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
            switch (operador)
            {
                case '+':
                    return Char.ToString(operador);
                    break;
                case '-':
                    return Char.ToString(operador);
                    break;
                case '*':
                    return Char.ToString(operador);
                    break;
                case '/':
                    return Char.ToString(operador);
                    break;
                default:
                    return Char.ToString('+');
                    break;
            }
        }



        public static double Operar(Numero num1, Numero num2, string operador)
        {

            double resultado;




            switch (operador)
            {
                case "+":
                    resultado = num1+num2;
                    break;
                case "-":
                    return Char.ToString(operador);
                    break;
                case "*":
                    return Char.ToString(operador);
                    break;
                case "/":
                    return Char.ToString(operador);
                    break;
                default:
                    return Char.ToString('+');
                    break;
            }



            //double resultado = num1 Convert.ToOperator(operador) num2;


            return;
        }




    }
}
