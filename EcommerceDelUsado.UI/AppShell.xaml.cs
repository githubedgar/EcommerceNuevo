using EcommerceDelUsado.UI.Views;

namespace EcommerceDelUsado.UI // ← ESTE NAMESPACE DEBE COINCIDIR CON x:Class EN EL XAML
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(VehiculoPage), typeof(VehiculoPage));
        }
    }
}
