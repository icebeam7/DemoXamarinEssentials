using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoXamarinEssentials
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Paginas.PaginaMenu();
        }
    }
}
