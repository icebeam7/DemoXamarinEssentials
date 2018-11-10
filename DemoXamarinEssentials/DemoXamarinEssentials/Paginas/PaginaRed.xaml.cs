using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoXamarinEssentials.ViewModels;

namespace DemoXamarinEssentials.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaRed : ContentPage
	{
		public PaginaRed ()
		{
			InitializeComponent ();

            BindingContext = new RedViewModel();
        }
    }
}