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
    public partial class SimpleCalculator : ContentPage
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnTambah_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 + bil2;

            txtHasil.Text = hasil.ToString();
            DisplayAlert("Hasil", bil1.ToString() + " + " + bil2.ToString() + " = " +
                hasil.ToString(), "OK");
        }

        private void btnKurang_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 - bil2;

            txtHasil.Text = hasil.ToString();
            DisplayAlert("Hasil", bil1.ToString() + " - " + bil2.ToString() + " = " +
                hasil.ToString(), "OK");
        }

        private void btnBagi_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 / bil2;

            txtHasil.Text = hasil.ToString();
            DisplayAlert("Hasil", bil1.ToString() + " / " + bil2.ToString() + " = " +
                hasil.ToString(), "OK");
        }

        private void btnKali_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 * bil2;

            txtHasil.Text = hasil.ToString();
            DisplayAlert("Hasil", bil1.ToString() + " * " + bil2.ToString() + " = " +
                hasil.ToString(), "OK");
        }
    }
}