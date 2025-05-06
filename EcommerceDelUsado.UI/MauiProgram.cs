
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
        var connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";
        builder.Services.AddSingleton<IVehiculoRepository>(sp => new VehiculoRepository(connectionString));

        // Caso de uso
        builder.Services.AddSingleton<ObtenerVehiculosUseCase>();

        // ViewModel (lo hacemos en el siguiente paso)
        builder.Services.AddTransient<VehiculoViewModel>();

        // Página
        builder.Services.AddTransient<VehiculoPage>();

        return builder.Build();
    }
}
