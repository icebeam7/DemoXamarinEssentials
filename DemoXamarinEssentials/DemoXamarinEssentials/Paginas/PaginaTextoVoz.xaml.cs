using DemoXamarinEssentials.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXamarinEssentials.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaTextoVoz : ContentPage
	{
		public PaginaTextoVoz ()
		{
			InitializeComponent ();

            BindingContext = new TextoVozViewModel();
        }
    }
}