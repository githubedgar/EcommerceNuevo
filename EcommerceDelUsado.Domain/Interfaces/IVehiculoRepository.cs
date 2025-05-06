


// EcommerceDelUsado.Domain/Interfaces/IVehiculoRepository.cs
using EcommerceDelUsado.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDelUsado.Domain.Interfaces
{
    public interface IVehiculoRepository
    {
        Task<List<Vehiculo>> ObtenerTodosAsync();
    }
}
