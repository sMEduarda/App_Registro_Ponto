using Microsoft.Maui.Devices.Sensors;

namespace App_Registro_Ponto;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    private async Task<Location?> ObterLocalizacao()
    {
        var request = new GeolocationRequest(GeolocationAccuracy.High);
        return await Geolocation.GetLocationAsync(request);
    }

    private async void OnRegistrarEntrada(object sender, EventArgs e)
    {
        var location = await ObterLocalizacao();

        if (location == null)
            return;

        lblEntradaHora.Text = $"Hora Entrada: {DateTime.Now}";
        lblEntradaLat.Text = $"Latitude Entrada: {location.Latitude}";
        lblEntradaLong.Text = $"Longitude Entrada: {location.Longitude}";
    }

    private async void OnRegistrarSaida(object sender, EventArgs e)
    {
        var location = await ObterLocalizacao();

        if (location == null)
            return;

        lblSaidaHora.Text = $"Hora Saída: {DateTime.Now}";
        lblSaidaLat.Text = $"Latitude Saída: {location.Latitude}";
        lblSaidaLong.Text = $"Longitude Saída: {location.Longitude}";
    }
}