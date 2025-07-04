﻿using System;
using Microsoft.Maui.Controls;
using EcommerceDelUsado.UI.Views; // IMPORTANTE para acceder a *Page

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
            // Navega a la página de vehículos (autos)
            await Navigation.PushAsync(new VehiculoPage());
        }

        private async void OnVerMotoTradicionalClicked(object sender, EventArgs e)
        {
            // Navega a la página de motos tradicionales
            await Navigation.PushAsync(new MotoTradPage());
        }

        private async void OnVerMotoElectricaClicked(object sender, EventArgs e)
        {
            // Navega a la página de motos electricas
            await Navigation.PushAsync(new MotoElecPage());
        }

        private async void OnVerBiciElectricaClicked(object sender, EventArgs e)
        {
            // Navega a la página de bicicletas electricas
            await Navigation.PushAsync(new BiciElecPage());
        }

        private async void OnVerBiciTradicionalClicked(object sender, EventArgs e)
        {
            // Navega a la página de bicicletas electricas
            await Navigation.PushAsync(new BiciTradPage());
        }
    }
}
