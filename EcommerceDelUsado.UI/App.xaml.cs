//using Microsoft.Maui.Controls;
//using EcommerceDelUsado.UI.Views; // Agrega esto para acceder a VehiculoPage

//namespace EcommerceDelUsado.UI;

//public partial class App : Microsoft.Maui.Controls.Application
//{
//    public App()
//    {
//        InitializeComponent();

//        var page = Microsoft.Maui.Controls.Application.Current.Handler?.MauiContext?.Services?.GetService<VehiculoPage>();
//        if (page is not null)
//        {
//            MainPage = page;
//        }
//        else
//        {
//            MainPage = new ContentPage { Content = new Label { Text = "Error al cargar la página VehiculoPage" } };
//        }

//    }
//}



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
