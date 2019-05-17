using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SignaturePad.Forms;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inter_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservar_Equipo : ContentPage
    {
        public Reservar_Equipo()
        {
            InitializeComponent();
        }
        public class SelectableData<T>
        {
            public T Data { get; set; }
            public bool Selected { get; set; }
        }
        public class ExampleData
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public List<SelectableData<ExampleData>> DataList { get; set; }

        // Clear signature pad
        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            Signature_Pad.Clear();
        }

        // Submit data to email
        private async void SubmitData_Clicked(object sender, EventArgs e)
        {
            Stream image = await Signature_Pad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            await DisplayAlert("Alert", "Tu informacion se envio exitosamente!", "Volver al inicio!");
            App.Current.MainPage = new MainPage();



            // Codigo que se va a utilizar cuando se conecte a un servidos IMAP
            /*
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                var email = new EmailMessageBuilder()
                  .To("michael2988@interfajardo.edu")
                  .Subject("Reservacion de Equipo")
                  .Body("Well hello there")
                  .Build();

                emailMessenger.SendEmail(email);
               */
        }
        private void ChangeRes_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Reservar_Equipo();
        }
    }     
}