using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoXamarinEssentials.ViewModels;

namespace DemoXamarinEssentials.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaCorreoSms : ContentPage
	{
		public PaginaCorreoSms ()
		{
			InitializeComponent ();

            BindingContext = new CorreoSmsViewModel();
		}
	}
}