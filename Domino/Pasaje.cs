using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Pasaje
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; }
        public Vuelo Vuelo { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public string Equipaje { get; set; } // LIGHT - CABINA  -  BODEGA -- es mejor hacerlo con un Enum
        public int Precio { get; set; }

        public Pasaje()
        {
            this.Id = UltimoId++;
        }

        public Pasaje (DateTime fecha, int precio)
        {
            this.Fecha = fecha;
            this.Precio = precio;
        }
    }
}
