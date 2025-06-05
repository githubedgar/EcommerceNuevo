using EcommerceDelUsado.Domain.Entities;
using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI.Views;

[QueryProperty(nameof(Vehiculo), "Vehiculo")]
public partial class DetalleVehiculoPage : ContentPage
{
    public Vehiculo Vehiculo
    {
        get => BindingContext as Vehiculo;
        set => BindingContext = value;
    }

    public DetalleVehiculoPage()
    {
        InitializeComponent();
    }
}
