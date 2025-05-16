using System;
using Microsoft.Maui.Controls;

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
            await Navigation.PushAsync(new Views.VehiculoPage());
        }
    }
}