using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Avion
    { 
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int CantidadDeAsientos { get; set; }
        public int Alcance { get; set; }
        public decimal CostoDeOperacion { get; set; }

        public Avion()
        { }

        public Avion(string fabricante, string modelo, int candidadDeAsientos, int Alcance, decimal costoDeOperacion)
        {
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.CantidadDeAsientos = candidadDeAsientos;
            this.Alcance = Alcance;
            this.CostoDeOperacion = costoDeOperacion;
        }
    }
}
