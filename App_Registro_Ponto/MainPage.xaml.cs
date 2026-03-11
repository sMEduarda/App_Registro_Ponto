namespace App_Registro_Ponto;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void AbrirRegistro(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroPage());
    }
}