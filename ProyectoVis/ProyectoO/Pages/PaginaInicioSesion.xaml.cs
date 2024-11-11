namespace ProyectoO.Pages;

public partial class PaginaInicioSesion : ContentPage
{
    public PaginaInicioSesion()
    {
        InitializeComponent();
    }

    private async void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro());
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Inicial();
    }



}