using Xamarin.Essentials;

namespace DemoXamarinEssentials.Modelos
{
    public class Bateria
    {
        public double Nivel { get; set; }
        public BatteryState Estado { get; set; }
        public BatteryPowerSource Fuente { get; set; }
    }
}
