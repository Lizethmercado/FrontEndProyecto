using ProyectoO.Pages;

namespace ProyectoO
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutPage { get; set; }
        public App()
        {
            InitializeComponent();

            

            MainPage = new NavigationPage(new PaginaInicioSesion());

        }
    }
}
