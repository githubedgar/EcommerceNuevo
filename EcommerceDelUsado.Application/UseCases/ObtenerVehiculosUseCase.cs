// EcommerceDelUsado.Application/UseCases/ObtenerVehiculosUseCase.cs
// Esta clase representa una acción de negocio específica: obtener todos los vehículos.
// Así mantenemos separada la lógica de aplicación respecto a la infraestructura.
using EcommerceDelUsado.Domain.Entities;
using EcommerceDelUsado.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDelUsado.Application.UseCases
{
    public class ObtenerVehiculosUseCase
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public ObtenerVehiculosUseCase(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }

        public async Task<List<Vehiculo>> EjecutarAsync()
        {
            return await _vehiculoRepository.ObtenerTodosAsync();
        }
    }
}
