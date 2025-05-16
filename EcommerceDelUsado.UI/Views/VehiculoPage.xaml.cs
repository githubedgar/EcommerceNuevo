using EcommerceDelUsado.UI.ViewModels;
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Infrastructure.Repositories;

namespace EcommerceDelUsado.UI.Views;

public partial class VehiculoPage : ContentPage
{
    public VehiculoPage()
    {
        InitializeComponent();

        // Cadena de conexi�n (aj�stala si est� en otro lado o si usas secrets)
        string connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        var repositorio = new VehiculoRepository(connectionString);
        var useCase = new ObtenerVehiculosUseCase(repositorio);
        BindingContext = new VehiculoViewModel(useCase);
    }
}