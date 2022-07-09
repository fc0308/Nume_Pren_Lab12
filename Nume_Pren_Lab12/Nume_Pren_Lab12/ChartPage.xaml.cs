﻿
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
            
            base.OnAppearing();
           var data = PopulateChartfromDB();
           var entries = Array.Empty<ChartEntry>();


         
            foreach (var CurrentData in await data)
            {
                var random = new Random();
                var color = String.Format("#{0:X6}" + random.Next(0x1000000));

                 entries =new[]
                {
                new ChartEntry(CurrentData.Value)
                {
                    Label = CurrentData.Month,
                    ValueLabel = CurrentData.Value.ToString(),
                    Color = SKColor.Parse(color)
                    }
                };
            }    
            
            var chart = new BarChart {Entries =entries,
                
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Horizontal,
                
                LabelTextSize = 30,
                BackgroundColor =033067

            };
            chartView.Chart = chart;


        }

        async Task<List<Sales>> PopulateChartfromDB()
        {
            var entries = await App.Database.GetSalesAsync(); //- modificam numele meyodei ce cea nou creata
            return entries;
            
        }

        Microcharts.ChartEntry[] PopulateChart()
        {
                      
            
          var entries = new[]
 {
     new ChartEntry(20)
    {
        Label = "Ian",
        ValueLabel = "20",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(26)
    {
        Label = "Feb",
        ValueLabel = "26",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(28)
    {
        Label = "Mar",
        ValueLabel = "28",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(32)
    {
        Label = "Apr",
        ValueLabel = "32",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(35)
    {
        Label = "May",
        ValueLabel = "35",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(40)
    {
        Label = "Jun",
        ValueLabel = "40",
        Color = SKColor.Parse("#77d065")
    },
     new ChartEntry(41)
    {
        Label = "Jul",
        ValueLabel = "41",
        Color = SKColor.Parse("#77d065")
    },
      new ChartEntry(36)
    {
        Label = "Aug",
        ValueLabel = "36",
        Color = SKColor.Parse("#C70039")
    },
       new ChartEntry(30)
    {
        Label = "Sep",
        ValueLabel = "30",
        Color = SKColor.Parse("#C70039")
    },
        new ChartEntry(45)
    {
        Label = "Oct",
        ValueLabel = "45",
        Color = SKColor.Parse("#77d065")
    },
        new ChartEntry(47)
    {
        Label = "Nov",
        ValueLabel = "47",
        Color = SKColor.Parse("#77d065")
    },
        new ChartEntry(49)
    {
        Label = "Dec",
        ValueLabel = "49",
        Color = SKColor.Parse("#77d065")
    },

      }; 
            return entries;

        }
       


    }
    }