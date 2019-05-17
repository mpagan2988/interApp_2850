using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inter_app
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class escoger_Reservacion : ContentPage
	{
		public escoger_Reservacion ()
		{
			InitializeComponent ();
		}

        private void BntSalon_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Reservar_Salon();
        }

        private void BntEquipo_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Reservar_Equipo();
        }
    }
}