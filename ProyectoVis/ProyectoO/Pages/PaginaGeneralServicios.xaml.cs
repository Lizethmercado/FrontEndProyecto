namespace ProyectoO.Pages;

public partial class PaginaGeneralServicios : ContentPage
{
	public PaginaGeneralServicios()
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

    private void OnClickedPaginaReserva(object sender, EventArgs e)
    {
        NavigationToPage(new PaginaReservas());
        OcultarDetalles();
    }
}