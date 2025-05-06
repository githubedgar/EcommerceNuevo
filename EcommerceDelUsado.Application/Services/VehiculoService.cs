// Objetivo: Implementar la lógica de aplicación que conecta con el repositorio para obtener los vehículos.
using EcommerceDelUsado.Application.Interfaces;
using EcommerceDelUsado.Domain.Entities;

namespace EcommerceDelUsado.Application.Services
{
    public class VehiculoService
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculoService(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }

        public async Task<IEnumerable<Vehiculo>> ObtenerVehiculosAsync()
        {
            return await _vehiculoRepository.GetAllVehiculosAsync();
        }
    }
}
