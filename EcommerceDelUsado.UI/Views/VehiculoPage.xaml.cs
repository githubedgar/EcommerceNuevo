// EcommerceDelUsado.UI/Views/VehiculoPage.xaml.cs
using EcommerceDelUsado.UI.ViewModels;

namespace EcommerceDelUsado.UI.Views;

public partial class VehiculoPage : ContentPage
{
    public VehiculoPage(VehiculoViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
