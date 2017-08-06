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
                "Satu","Dua","Tiga","Empat","Lima"
            };

            listView.ItemsSource = items;
        }
    }
}