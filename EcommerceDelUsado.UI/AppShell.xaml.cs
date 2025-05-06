using EcommerceDelUsado.UI.Views;


namespace EcommerceDelUsado
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
