using CarListApp.Maui.Views;
using Microsoft.Maui.Controls;
namespace CarListApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
        }
    }
}
