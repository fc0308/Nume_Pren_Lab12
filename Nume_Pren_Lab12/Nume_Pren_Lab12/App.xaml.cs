using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Nume_Pren_Lab12.Data;

namespace Nume_Pren_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }



        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
           
           // MainPage = new NavigationPage(new Page1());
            MainPage = new NavigationPage(new ChartPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
