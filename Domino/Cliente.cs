using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Cliente
    {
        public string CedulaIdentidad { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Nacionalidad { get; set; }
        public string TipoDeCliente { get; set; }
        //PREMIUM - OCACIONALES (P: adheridos al programa de ventajas de la aero y se conoce puntos que tienen
        // O: se conoce si son elegibles para regalo de cabina (la elegibilidad se determina de forma aleatoria al ingresar al sistema)

        public Cliente()
        {

        }


    }
}
