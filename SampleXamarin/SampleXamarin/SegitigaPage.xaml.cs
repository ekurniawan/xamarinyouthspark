using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegitigaPage : ContentPage
    {
        public SegitigaPage()
        {
            InitializeComponent();
        }

        private void btnAlas_Clicked(object sender, EventArgs e)
        {
            double alas = Convert.ToDouble(txtAlas.Text);
            double tinggi = Convert.ToDouble(txtTinggi.Text);
            double hasil = 0.5 * alas * tinggi;

            DisplayAlert("Hasil", "Luas Segitiga : " + hasil.ToString(),"OK");
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            txtAlas.Text = "";
            txtTinggi.Text = "";
            txtAlas.Focus();
        }
    }
}