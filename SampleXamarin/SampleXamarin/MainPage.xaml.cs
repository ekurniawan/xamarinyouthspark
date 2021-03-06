﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void menuKalkulator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCalculator());
        }

        private void menuSegitiga_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegitigaPage());
        }

        private void menuGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void menuList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContohListView());
        }

        private void menuBarang_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListBarangPage());
        }
    }
}
