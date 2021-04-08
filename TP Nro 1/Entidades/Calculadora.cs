﻿using System;
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
            

            
            switch (ValidarOperador(char.Parse(operador)))
            {
                case "+":
                    return (num1 + num2);
                    break;
                case "-":
                    return (num1 - num2);
                    break;
                case "*":
                    return (num1 * num2);
                    break;
                case "/":
                    return (num1 / num2);
                    break;
                default:
                    return 0;
                    break;
            }
           
        }




    }
}
