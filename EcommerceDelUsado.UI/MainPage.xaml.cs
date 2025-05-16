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
            await Navigation.PushAsync(new VehiculoPage()); // ✅ Ya reconoce VehiculoPage
        }
    }
}