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
           
            await Shell.Current.GoToAsync("VehiculoPage");
        }
        private async void OnVerMotoTradicionalClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotosTradicionalesPage()); 

        }

    }
}