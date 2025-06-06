using EcommerceDelUsado.Domain.Entities;
using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;
using System;

namespace EcommerceDelUsado.UI.Views
{
    [QueryProperty(nameof(Vehiculo), "Vehiculo")]
    public partial class DetalleMotoElecPage : ContentPage
    {
        public Vehiculo Vehiculo
        {
            get => BindingContext as Vehiculo;
            set => BindingContext = value;
        }

        public DetalleMotoElecPage()
        {
            InitializeComponent();
        }

        private async void OnPagarClicked(object sender, EventArgs e)
        {
            // Simulación de pasarela de pago para prototipo
            await DisplayAlert(
                "Pago realizado",
                "Gracias por su compra. En un plazo de 24 horas entregaremos su carro junto con la documentación.",
                "Aceptar");
        }

        private async void OnWhatsAppClicked(object sender, EventArgs e)
        {
            string numero = "573005764507"; // Cambiar por el número real sin '+' ni espacios
            string mensaje = Uri.EscapeDataString(
                $"Hola, deseo más información sobre el vehículo {Vehiculo.Marca} {Vehiculo.Modelo}.");
            string url = $"https://wa.me/{numero}?text={mensaje}";

            try
            {
                await Launcher.Default.OpenAsync(url);
            }
            catch (Exception)
            {
                await DisplayAlert("Error", "No se pudo abrir WhatsApp.", "OK");
            }
        }
    }
}
