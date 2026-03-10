using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;

namespace App_Registro_Ponto.Views;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarPonto(object sender, EventArgs e)
    {
        var location = await Geolocation.GetLastKnownLocationAsync();

        if (location != null)
        {
            lblLocalizacao.Text = $"Lat: {location.Latitude} | Long: {location.Longitude}";
            lblHorario.Text = $"Registrado em: {DateTime.Now}";
        }
        else
        {
            lblLocalizacao.Text = "Não foi possível obter localização.";
        }
    }
}