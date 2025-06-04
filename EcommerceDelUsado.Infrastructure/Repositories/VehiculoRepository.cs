

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
                var cmd = new SqlCommand("SELECT Id, Marca, Modelo, Año, Precio, Tipo FROM Vehiculos", conn);

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
                        Tipo = reader.GetString(5)
                    });
                }
            }

            return vehiculos;
        }
    }
}
