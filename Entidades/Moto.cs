using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Creada herencia
    /// </summary>
    public class Moto : Vehiculo
    {
        /// <summary>
        /// Constructor a padre
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Moto(EMarca marca, string chasis, ConsoleColor color)
            :base(chasis,marca,color)
        {

        }

        /// <summary>
        /// Las motos son chicas
        /// Arreglado.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Sobreescrita mostrar de padre, reutilizado el codigo.
        /// </summary>
        /// <returns>Datos de Vehiculo+Moto</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.Append("TAMAÑO :");
            sb.AppendLine(this.Tamanio.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
