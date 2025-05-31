using MauiAppHotel.Models;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Pages
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            NewMethod();
            BindingContext = evento;
        }

        private static void NewMethod() => InitializeComponent();

        private static void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}