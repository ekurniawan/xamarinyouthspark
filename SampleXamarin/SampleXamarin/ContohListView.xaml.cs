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
    public partial class ContohListView : ContentPage
    {
        public ContohListView()
        {
            InitializeComponent();

            List<string> items = new List<string>
            {
                "Belajar Xamarin","Belajar Android","Belajar C#","Belajar IOS",
                "Belajar Construct2"
            };

            listView.ItemsSource = items;
            listView.ItemTapped += ListView_ItemTapped;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string data = e.Item.ToString();
            DisplayAlert("Konfirmasi", "Anda memilih data: " + data, "OK");
        }
    }
}