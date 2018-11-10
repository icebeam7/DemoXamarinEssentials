using DemoXamarinEssentials.Modelos;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.ViewModels
{
    public class MapaViewModel : BaseViewModel
    {
        private Mapa mapa;
        public Command MuestraMapaCommand { get; set; }

        private double latitud;

        public double Latitud
        {
            get { return mapa.Latitud; }
            set { mapa.Latitud = value; OnPropertyChanged(); }
        }

        private double longitud;

        public double Longitud
        {
            get { return mapa.Longitud; }
            set { mapa.Longitud = value; OnPropertyChanged(); }
        }

        public MapaViewModel()
        {
            mapa = new Mapa();

            MuestraMapaCommand = new Command(async () =>
            {
                await Maps.OpenAsync(new Location(Latitud, Longitud));
            });

            Inicializar();
        }
        
        async Task Inicializar()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    Latitud = location.Latitude;
                    Longitud = location.Longitude;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
