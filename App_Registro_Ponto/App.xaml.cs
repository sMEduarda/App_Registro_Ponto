using App_Registro_Ponto.Views;

namespace App_Registro_Ponto;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new RegistroPage();
    }
}