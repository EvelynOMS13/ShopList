using ShopList.Maui.Views;

namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registra las rutas de navegacion de las paginas
            //de la aplicacion
            Routing.RegisterRoute(
                nameof(EditShopListIemPage),
                typeof(EditShopListIemPage));
        }
    }
}
