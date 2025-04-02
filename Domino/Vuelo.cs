using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Vuelo
    {
        public string NumeroDeVuelo { get; set; }
        public Ruta Ruta { get; set; }
        public Avion Avion { get; set; }
        public string Frecuencia { get; set; }

        public Vuelo()
        {
            
        }

        public Vuelo(string numeroDevuelo, string frencuencia)
        {
            this.NumeroDeVuelo = numeroDevuelo;
            this.Frecuencia = frencuencia;
        }

        public void ValidarAlcance()
        {
            if (Avion.Alcance < Ruta.Distancia)
            {
                throw new Exception("La distancia de la ruta es demasiado larga para este avión!!");
            }
        }

        public void AsociarCategoria(Ruta ruta)
        {
            this.Ruta = ruta;
        }

        public void AsociarCategoria(Avion avion)
        {
            this.Avion = avion;
        }

    }
}
