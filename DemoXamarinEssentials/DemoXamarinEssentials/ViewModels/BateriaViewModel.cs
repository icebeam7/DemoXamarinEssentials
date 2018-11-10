using DemoXamarinEssentials.Modelos;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.ViewModels
{
    public class BateriaViewModel : BaseViewModel
    {
        private Bateria bateria;
        private Command CambioStatusCommand;

        private double nivel;

        public double Nivel
        {
            get { return bateria.Nivel; }
            set { bateria.Nivel = value; OnPropertyChanged(); }
        }

        private BatteryState estado;

        public BatteryState Estado
        {
            get { return bateria.Estado; }
            set { bateria.Estado = value; OnPropertyChanged(); }
        }

        private BatteryPowerSource fuente;

        public BatteryPowerSource Fuente
        {
            get { return bateria.Fuente; }
            set { bateria.Fuente = value; OnPropertyChanged(); }
        }

        public BateriaViewModel()
        {
            bateria = new Bateria()
            {
                Nivel = Battery.ChargeLevel,
                Estado = Battery.State,
                Fuente = Battery.PowerSource
            };

            Battery.BatteryChanged += (s, e) => 
            {
                CambioStatusCommand.Execute(e);
            };

            CambioStatusCommand = new Command<BatteryChangedEventArgs>((e) =>
            {
                Nivel = e.ChargeLevel;
                Estado = e.State;
                Fuente = e.PowerSource;
            });
        }
    }
}