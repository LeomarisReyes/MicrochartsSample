using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using Microcharts;

namespace MicrochartsSample.Views
{
    public partial class MicrochartPage : ContentPage
    {
        public MicrochartPage()
        {

            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                this.Padding = new Thickness(0, 70, 0, 0); 
            
            BindingContext = new ViewModel.DisplayChartViewModel(); 
        }   
    }
}
