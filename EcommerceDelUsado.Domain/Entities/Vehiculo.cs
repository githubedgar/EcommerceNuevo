
using System.IO;
public class Vehiculo
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public string Color { get; set; }
    public int Kilometraje { get; set; }
    public string Transmision { get; set; }
    public decimal Precio { get; set; }
    public string Descripcion { get; set; }

   
    public string Imagen1 => Marca.ToLower() + "1.png";
    public string Imagen2 => Marca.ToLower() + "2.png";





}
