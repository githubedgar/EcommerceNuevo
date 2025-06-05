

// EcommerceDelUsado.Infrastructure/Repositories/VehiculoRepository.cs
using EcommerceDelUsado.Domain.Entities;
using EcommerceDelUsado.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDelUsado.Infrastructure.Repositories
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly string _connectionString;

        public VehiculoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Vehiculo>> ObtenerTodosAsync()
        {
            var vehiculos = new List<Vehiculo>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                var cmd = new SqlCommand(@"SELECT Id, Marca, Modelo, Año, Precio, Tipo, Color, Kilometraje, Transmision, Descripcion 
                           FROM Vehiculos", conn);

                var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    vehiculos.Add(new Vehiculo
                    {
                        Id = reader.GetInt32(0),
                        Marca = reader.GetString(1),
                        Modelo = reader.GetString(2),
                        Año = reader.GetInt32(3),
                        Precio = reader.GetDecimal(4),
                        Tipo = reader.GetString(5),
                        Color = reader.IsDBNull(6) ? "" : reader.GetString(6),  // Usamos reader.IsDBNull(x) ? ... para evitar errores si el campo en la base de datos está NULL.
                        Kilometraje = reader.IsDBNull(7) ? 0 : reader.GetInt32(7), // También asignamos un valor por defecto ("" o 0) si el dato no existe.
                        Transmision = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        Descripcion = reader.IsDBNull(9) ? "" : reader.GetString(9)
                    });


                }
            }

            return vehiculos;
        }
    }
}
