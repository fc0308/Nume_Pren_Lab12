using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nume_Pren_Lab12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && Password.Text == "admin") {
                Navigation.PushAsync(new ChartPage());
                    }
            else { DisplayAlert("Ups...", "Datele nu sunt corecte", "OK");
            }
        }
    }
}