using System;
using System.Collections.Generic;
using DemoXamarinEssentials.Modelos;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DemoXamarinEssentials.ViewModels
{
    public class CorreoSmsViewModel : BaseViewModel
    {
        private Mensaje mensaje;
        public Command EnvioCorreoCommand { get; set; }
        public Command EnvioSmsCommand { get; set; }

        private string asunto;

        public string Asunto
        {
            get { return mensaje.Asunto; }
            set { mensaje.Asunto = value; OnPropertyChanged(); }
        }

        private string texto;

        public string Texto
        {
            get { return mensaje.Texto; }
            set { mensaje.Texto = value; OnPropertyChanged(); }
        }

        private string para;

        public string Para
        {
            get { return mensaje.Para; }
            set { mensaje.Para = value; OnPropertyChanged(); }
        }

        public CorreoSmsViewModel()
        {
            mensaje = new Mensaje();

            EnvioCorreoCommand = new Command(async () =>
            {
                try
                {
                    var email = new EmailMessage
                    {
                        Subject = Asunto,
                        Body = texto,
                        To = new List<string>() { Para }
                    };

                    await Email.ComposeAsync(email);
                }
                catch(Exception ex)
                {

                }
            });

            EnvioSmsCommand = new Command(async () =>
            {
                try
                {
                    var sms = new SmsMessage
                    {
                        Body = texto,
                        Recipients = new List<string>() { para }
                    };

                    await Sms.ComposeAsync(sms);
                }
                catch(Exception ex)
                {

                }
            });
        }
    }
}
