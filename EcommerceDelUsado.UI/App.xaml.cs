using Microsoft.Maui.Controls;

namespace EcommerceDelUsado.UI;
public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
