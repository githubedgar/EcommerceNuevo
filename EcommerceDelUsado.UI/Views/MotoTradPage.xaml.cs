using EcommerceDelUsado.UI.ViewModels;
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Infrastructure.Repositories;
using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI.Views;

public partial class MotoTradPage : ContentPage
{
    public MotoTradPage()
    {
        InitializeComponent();

        string connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        var repositorio = new VehiculoRepository(connectionString);
        var useCase = new ObtenerVehiculosUseCase(repositorio);
        BindingContext = new VehiculoViewModel(useCase, "MotoTradicional"); // Filtra por tipo. MotoTradicional es el campo "Tipo" en la DB.
    }
}
