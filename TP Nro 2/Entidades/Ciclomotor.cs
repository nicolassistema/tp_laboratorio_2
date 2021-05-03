using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor( EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis,  color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return this.Tamanio;
            }
        }

         public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine(String.Format("TAMAÑO : {0}", this.Tamanio));
             sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
