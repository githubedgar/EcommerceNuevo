
// EcommerceDelUsado.UI/MauiProgram.cs
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Domain.Interfaces;
using EcommerceDelUsado.Infrastructure.Repositories;
using EcommerceDelUsado.UI;
using EcommerceDelUsado.UI.ViewModels;
using EcommerceDelUsado.UI.Views;



public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Agrega esto: cadena de conexión a tu BD
        // Esto define la cadena de conexión usada por el repositorio para conectarse a SQL Server.
        var connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";
        // Inyecta el repositorio VehiculoRepository como implementación de la interfaz IVehiculoRepository. Se declara como
        // Singleton porque no necesita múltiples instancias.
        builder.Services.AddSingleton<IVehiculoRepository>(sp => new VehiculoRepository(connectionString));

        // Caso de uso
        // Inyecta el caso de uso ObtenerVehiculosUseCase, que depende del repositorio anterior. También como Singleton.
        builder.Services.AddSingleton<ObtenerVehiculosUseCase>();

        // ViewModel (lo hacemos en el siguiente paso)
        // El ViewModel es Transient porque puede cambiar en cada instancia de la página. Correcto para ViewModels en MAUI.
        builder.Services.AddTransient<VehiculoViewModel>();

        // Página
        // La vista VehiculoPage también es Transient, lo que permite múltiples instancias limpias si es necesario.
        builder.Services.AddTransient<VehiculoPage>();

        return builder.Build();
    }
}
