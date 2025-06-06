using EcommerceDelUsado.UI.Views;

namespace EcommerceDelUsado.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(VehiculoPage), typeof(VehiculoPage));
            Routing.RegisterRoute(nameof(DetalleVehiculoPage), typeof(DetalleVehiculoPage));
            Routing.RegisterRoute(nameof(DetalleMotoTradPage), typeof(DetalleMotoTradPage));
            Routing.RegisterRoute(nameof(DetalleMotoElecPage), typeof(DetalleMotoElecPage));
            Routing.RegisterRoute(nameof(DetalleBiciTradPage), typeof(DetalleBiciTradPage));
            Routing.RegisterRoute(nameof(DetalleBiciElecPage), typeof(DetalleBiciElecPage));
        }
    }
}
