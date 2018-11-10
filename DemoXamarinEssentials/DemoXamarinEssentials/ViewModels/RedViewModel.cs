using System.Linq;
using System.Collections.Generic;
using DemoXamarinEssentials.Modelos;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.ViewModels
{
    public class RedViewModel : BaseViewModel
    {
        private Red red;
        private Command CambioStatusCommand;

        private List<ConnectionProfile> perfil;

        public List<ConnectionProfile> Perfil
        {
            get { return red.Perfil; }
            set { red.Perfil = value; OnPropertyChanged(); }
        }

        private NetworkAccess conexion;

        public NetworkAccess Conexion
        {
            get { return red.Conexion; }
            set { red.Conexion = value; OnPropertyChanged(); }
        }

        public RedViewModel()
        {
            red = new Red()
            {
                Perfil = Connectivity.Profiles.ToList(),
                Conexion = Connectivity.NetworkAccess
            };

            Connectivity.ConnectivityChanged += (s, e) =>
            {
                CambioStatusCommand.Execute(e);
            };

            CambioStatusCommand = new Command<ConnectivityChangedEventArgs>((e) =>
            {
                Perfil = e.Profiles.ToList();
                Conexion = e.NetworkAccess;
            });
        }
    }
}
