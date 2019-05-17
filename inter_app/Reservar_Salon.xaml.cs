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
	public partial class Reservar_Salon : ContentPage
	{
		public Reservar_Salon ()
		{
			InitializeComponent ();
		}


        // Clear signature pad
        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            Signature_Pad.Clear();
        }

        // Submit data to email
        private async void SubmitData_Clicked(object sender, EventArgs e)
        {
            /*
            String nomSol, salon, equipoSal, prog, equipo;
            DatePicker fechaHoy;
            DatePicker fechaUso;
            TimePicker horaUso;
            */

            Stream image = await Signature_Pad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            await DisplayAlert("Alert", "Tu informacion se envio exitosamente!", "Volver al inicio!");
            App.Current.MainPage = new MainPage();

            /*
            fechaHoy = fechaDiaE;
            nomSol = nombreSolicitanteE.Text;
            salon = numSalonE.Text;
            equipoSal = matYEquipoE.Text;
            prog = progE.Text;
            equipo = equipoE.Text;
            fechaUso = fechaUsoE;
            horaUso = horaUsoE;


            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                var email = new EmailMessageBuilder()
                  .To("email@email.com")
                  .Subject("Reservacion de Equipo")
                  .Body(fechaHoy + " - " + nomSol + " - " + salon + " - " + equipoSal + " - " + prog + " - " + equipo + " - " + fechaUso + " - " + horaUso + image)
                  .Build();

                emailMessenger.SendEmail(email);
            }
            */
        }

        private void ChangeRes_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Reservar_Equipo();
        }
    }
}