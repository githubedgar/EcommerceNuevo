using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceDelUsado.Domain.Entities;

namespace EcommerceDelUsado.Application.Interfaces
{
    public interface IVehiculoRepository
    {
        Task<IEnumerable<Vehiculo>> GetAllVehiculosAsync();
    }
}
