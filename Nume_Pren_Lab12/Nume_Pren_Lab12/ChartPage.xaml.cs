using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts.Forms;
using Microcharts;
using Nume_Pren_Lab12.Models;
using SkiaSharp;

namespace Nume_Pren_Lab12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartPage : ContentPage
    {
        public ChartPage()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            Microcharts.ChartEntry[] data;
            base.OnAppearing();
            data=PopulateChart();
            //dupa ce faceti metoda care interogheaza db apelati in loc de PopulateChart metoda PopulateChartfromDB
            var chart = new LineChart { Entries = data };
            chartView.Chart = chart;


        }

        async Task<List<ShopList>> PopulateChartfromDB()
        {
            var entries = await App.Database.GetShopListsAsync(); //- modificam numele meyodei ce cea nou creata
            return entries;
            
        }

        Microcharts.ChartEntry[] PopulateChart()
        {
                      
            
          var entries = new[]
 {
     new ChartEntry(212)
    {
        Label = "UWP",
        ValueLabel = "112",
        Color = SKColor.Parse("#2c3e50")
    },
    new ChartEntry(248)
    {
        Label = "Android",
        ValueLabel = "648",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(128)
    {
        Label = "iOS",
        ValueLabel = "428",
        Color = SKColor.Parse("#b455b6")
    },
    new ChartEntry(514)
    {
        Label = "Forms",
        ValueLabel = "214",
        Color = SKColor.Parse("#3498db")
    }

      }; 
            return entries;

        }
       


    }
    }