using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Ruta
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; }
        public string AeropuertoDeSalida { get; set; }
        public string AeropuertoDeLlegada { get; set; }
        public int Distancia { get; set; }

        public Ruta()
        {
            this.Id = UltimoId++;
        }

        public Ruta(string aeropuertoDeSalida, string aeropuertoDeLlegada, int distancia)
        {
            this.Id = UltimoId;
            this.AeropuertoDeSalida = aeropuertoDeSalida;
            this.AeropuertoDeLlegada = aeropuertoDeLlegada;
            this.Distancia = distancia;
        }


    }
}
