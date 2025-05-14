

//// EcommerceDelUsado.UI/App.xaml.cs
//using EcommerceDelUsado.UI.Views;

//namespace EcommerceDelUsado.UI;

//public partial class App : Microsoft.Maui.Controls.Application
//{
//    public App(VehiculoPage page)
//    {
//        InitializeComponent();

//        MainPage = new NavigationPage(page);
//    }
//}



using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        InitializeComponent();

        // Confirmación del flujo correcto
        MainPage = new AppShell();
    }
}
