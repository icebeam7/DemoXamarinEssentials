using DemoXamarinEssentials.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXamarinEssentials.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaMapa : ContentPage
	{
		public PaginaMapa ()
		{
			InitializeComponent ();

            BindingContext = new MapaViewModel();
		}
	}
}