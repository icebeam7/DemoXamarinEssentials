using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoXamarinEssentials.ViewModels;

namespace DemoXamarinEssentials.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaBateria : ContentPage
	{
		public PaginaBateria ()
		{
			InitializeComponent ();

            BindingContext = new BateriaViewModel();
		}
	}
}