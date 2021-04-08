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




        public static bool EsBinario(string binario)
        {
            char[] array = binario.ToCharArray();
            int contador = 0;

            foreach (var item in array)
            {
                if (item == '1' || item == '0')
                {
                    contador++;
                }
            }
            if (contador == array.Length)
            {
                return true;
            }
            return false;
        }



        public static string BinarioDecimal(string binario)
        {
            string salida = "Valor inválido";
            if (EsBinario(binario))
            {
                char[] array = binario.ToCharArray();
                Array.Reverse(array);

                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
                salida = sum.ToString(); ;
            }
            return salida;
        }



       public static string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroEntero = (int)numero;

            if (numeroEntero > 0)
            {
                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }
                   numeroEntero = numeroEntero / 2;
                }
            }
            else
            {
                if (numeroEntero == 0)
                {
                    resultado = "0";
                }
                else
                {
                    resultado = "Valor invalido";
                }
            }
            return resultado;
        }

        public static string DecimalBinario(string numero)
        {
            return DecimalBinario(double.Parse(numero));
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

