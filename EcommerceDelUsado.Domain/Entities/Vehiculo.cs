namespace EcommerceDelUsado.Domain.Entities
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }          // Automóvil, Motocicleta, Bicicleta
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public int Kilometraje { get; set; }
        public string Transmision { get; set; }   // Manual, Automática
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}