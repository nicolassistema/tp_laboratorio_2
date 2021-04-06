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
        //constructores
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero) : this()
        {
            this.numero = numero;
        }



        public Numero(string numero)
        {
            //this.SetNumero = numero;
        }


        private double ValidarNumero(string strNumero)
        {
            double auxNumero;

            if (!double.TryParse(strNumero, out auxNumero))
            {
                auxNumero = 0;
            }

            return auxNumero;
        }

        public string SetNumero { set => numero = ValidarNumero(value); }



    }
}
