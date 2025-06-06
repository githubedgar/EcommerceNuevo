using EcommerceDelUsado.UI.ViewModels;
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Infrastructure.Repositories;
using EcommerceDelUsado.Domain.Entities; // Vehiculo esta aquí.
using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI.Views;

public partial class BiciElecPage : ContentPage
{
    public BiciElecPage()
    {
        InitializeComponent();

        string connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        var repositorio = new VehiculoRepository(connectionString);
        var useCase = new ObtenerVehiculosUseCase(repositorio);
        BindingContext = new VehiculoViewModel(useCase, "BicicletaElectrica"); // Filtra por tipo. BicicletaTradicional es el campo "Tipo" en la DB.
    }

    private async void OnBiciElecSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedVehiculo = e.CurrentSelection.FirstOrDefault() as Vehiculo;
        if (selectedVehiculo == null)
            return;

        // Navegar a la página de detalles
        await Shell.Current.GoToAsync(nameof(DetalleBiciElecPage), new Dictionary<string, object>
        {
            { "Vehiculo", selectedVehiculo }
        });

        // Limpiar la selección
        ((CollectionView)sender).SelectedItem = null;
    }
}

