using Microsoft.Maui.Controls;
using System.Globalization;

namespace EcommerceDelUsado.UI;
public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-CO");

        InitializeComponent();

        MainPage = new AppShell();

    }
}
