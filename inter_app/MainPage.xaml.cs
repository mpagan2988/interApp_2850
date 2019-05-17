using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace inter_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BntLogIn_Clicked(object sender, EventArgs e)
        {
            String userAdmin = "admin", passAdmin = "admin";

            String username = user.Text;
            String password = pass.Text;

            if (username == userAdmin && password == passAdmin)
            {
                App.Current.MainPage = new escoger_Reservacion();
            }
            else
                DisplayAlert("Error!", "Credenciales invalidas! ", " Volver a intentar");
        }
    }
}
