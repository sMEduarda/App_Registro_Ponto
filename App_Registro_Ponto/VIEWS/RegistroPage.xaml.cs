using App_Registro_Ponto.Services;

namespace App_Registro_Ponto.Views;

public partial class RegistroPage : ContentPage
{
    GeolocationService geoService = new GeolocationService();

    public RegistroPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarPonto(object? sender, EventArgs e)
    {
        var location = await geoService.GetLocation();

        if (location != null)
        {
            lblLocalizacao.Text = $"Lat: {location.Latitude} | Long: {location.Longitude}";
        }
        else
        {
            lblLocalizacao.Text = "Não foi possível obter localização";
        }
    }
}