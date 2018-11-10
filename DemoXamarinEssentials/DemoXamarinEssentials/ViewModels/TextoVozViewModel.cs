using DemoXamarinEssentials.Modelos;
using System;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.ViewModels
{
    public class TextoVozViewModel : BaseViewModel
    {
        private TextoVoz textoVoz;
        public Command HablaCommand { get; set; }

        private string texto;

        public string Texto
        {
            get { return textoVoz.Texto; }
            set { textoVoz.Texto = value; OnPropertyChanged(); }
        }

        private float volumen;

        public float Volumen
        {
            get { return textoVoz.Volumen; }
            set { textoVoz.Volumen = value; OnPropertyChanged(); }
        }

        private float pitch;

        public float Pitch
        {
            get { return textoVoz.Pitch; }
            set { textoVoz.Pitch = value; OnPropertyChanged(); }
        }

        public TextoVozViewModel()
        {
            textoVoz = new TextoVoz()
            {
                Volumen = .75f,
                Pitch = 1.0f
            };

            HablaCommand = new Command(async () =>
            {
                try
                {
                    var locales = await TextToSpeech.GetLocalesAsync();
                    var locale = locales.FirstOrDefault();

                    var settings = new SpeakSettings()
                    {
                        Pitch = Pitch,
                        Volume = Volumen,
                        Locale = locale
                    };

                    await TextToSpeech.SpeakAsync(Texto, settings);
                }
                catch(Exception ex)
                {

                }
            });
        }
    }
}
