using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        //atributos
        private double numero;

        #region "Constructores"
        //constructores
        public Numero()//consutructor por defecto
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion

        #region propiedades             
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region "metodos varios"
        private static double ValidarNumero(string strNumero)
        {
            double auxNumero;

            if (!double.TryParse(strNumero, out auxNumero))
            {
                auxNumero = 0;
            }
            return auxNumero;
        }


        public static string BinarioDecimal(string binario)
        {
            int contador = 0;
            foreach (var item in binario)
            {
                if (item == '1' || item == '0')
                {
                //    Console.WriteLine("Entro al if");
                    contador++;
                }
            }

            if (contador == binario.Length)
            {
             //   return "Valor correcto";
                //conversion
                //return;
            }
            

            return "Valor inválido";
        }



        #endregion


        #region operadores
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }


        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }

        #endregion



    }


}

