using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Voltar para a página anterior
            Navigation.PopAsync();
        }
    }
}
