using EcommerceDelUsado.UI.ViewModels;
using EcommerceDelUsado.Application.UseCases;
using EcommerceDelUsado.Infrastructure.Repositories;
using EcommerceDelUsado.Domain.Entities; // Vehiculo esta aqu�.
using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI.Views;

public partial class MotoElecPage : ContentPage
{
    public MotoElecPage()
    {
        InitializeComponent();

        string connectionString = "Server=localhost;Database=EcommerceDelUsadoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        var repositorio = new VehiculoRepository(connectionString);
        var useCase = new ObtenerVehiculosUseCase(repositorio);
        BindingContext = new VehiculoViewModel(useCase, "MotoElectrica"); // Filtra por tipo. Auto es el campo "Tipo" en la DB.
    }

    private async void OnMotoElecSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedVehiculo = e.CurrentSelection.FirstOrDefault() as Vehiculo;
        if (selectedVehiculo == null)
            return;

        // Navegar a la p�gina de detalles
        await Shell.Current.GoToAsync(nameof(DetalleMotoElecPage), new Dictionary<string, object>
        {
            { "Vehiculo", selectedVehiculo }
        });

        // Limpiar la selecci�n
        ((CollectionView)sender).SelectedItem = null;
    }
}

