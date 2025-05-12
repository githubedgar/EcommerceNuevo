


// EcommerceDelUsado.UI/App.xaml.cs
using EcommerceDelUsado.UI.Views;

namespace EcommerceDelUsado.UI;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App(VehiculoPage page)
    {
        InitializeComponent();

        MainPage = new NavigationPage(page);
    }
}
