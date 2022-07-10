using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Nume_Pren_Lab12.Data;
using System.Collections.Generic;

namespace Nume_Pren_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }



        public App()
        {
            Database = new ShoppingListDatabase(new RestService());

             MainPage = new NavigationPage(new ChartPage());

        /*    List<ContentPage> pgs = new List<ContentPage>();
            pgs.Add(new BarChartPage());
            pgs.Add(new LineChartPage());
            var pg = new CarouselPage
            {
                Title = "MetroApp",
                Children = {
             pgs[0],pgs[1],
         }
            };
            MainPage = pg;
        */
            
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
