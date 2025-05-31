using MauiAppHotel.Models;
using System;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        // Atribui a lista ao Picker (o Picker já está nomeado como "pck_quarto" no XAML)
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        // Define os limites de datas para check-in e check-out
        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Hospedagem hospedagem = new()
            {
                QuartoSelecionado = pck_quarto.SelectedItem as Quarto,
                QntAdultos = (int)stp_adultos.Value,
                QntCriancas = (int)stp_criancas.Value,
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date
            };

            // Aqui você pode adicionar lógica para usar a variável `hospedagem`, como:
            // await Navigation.PushAsync(new ProximaPagina(hospedagem));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
        }
    }
}
