
// Ruta: EcommerceDelUsado.Application/Common/Interfaces/IDbConnectionFactory.cs

using System.Data;

namespace EcommerceDelUsado.Application.Common.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
