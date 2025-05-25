using System;
using Microsoft.Maui.Controls;
using EcommerceDelUsado.UI.Views; // IMPORTACIÓN NECESARIA

namespace EcommerceDelUsado.UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnVerVehiculosClicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync(nameof(VehiculoPage));
            await Navigation.PushAsync(new VehiculoPage()); // Ya reconoce VehiculoPage
        }
        private async void OnVerMotoTradicionalClicked(object sender, EventArgs e)
        {
            // Aquí puedes navegar a otra página, por ejemplo:
            await Navigation.PushAsync(new MotosTradicionalesPage()); // Ya reconoce MotosTradicionalesPage

            // O mostrar un mensaje temporal (para pruebas):
            // await DisplayAlert("Moto Tradicional", "Has seleccionado Moto Tradicional", "OK");
        }

    }
}