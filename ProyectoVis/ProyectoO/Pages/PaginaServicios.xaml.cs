namespace ProyectoO.Pages;

public partial class PaginaServicios : ContentPage
{
    public PaginaServicios()
    {
        InitializeComponent();


    }

    public static void NavigationToPage(ContentPage nuevaPagina)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
    }


    public static void OcultarDetalles()
    {
        App.FlyoutPage.IsPresented = false;
    }

    private void OnVerservicioClicked(object sender, EventArgs e)
    {
        NavigationToPage(new PaginaGeneralServicios());
        OcultarDetalles();
    }
}
