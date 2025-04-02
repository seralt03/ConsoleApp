namespace Domino
{
    public class Aeropuerto
    {
        public string CodigoIata { get; set; }
        public string Ciudad { get; set; }
        public decimal CostoDeOperacion { get; set; }
        public decimal CostoDeTasas { get; set; }

        public Aeropuerto() { }


        public Aeropuerto(string codigoIata, string ciudad, decimal costoDeOperacion, decimal costoDeTasas)
        {
            this.CodigoIata = codigoIata;
            this.Ciudad = ciudad;
            this.CostoDeOperacion = costoDeOperacion;
            this.CostoDeTasas = costoDeTasas;
        }

    }
}
