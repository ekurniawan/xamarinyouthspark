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
    public partial class ListBarangPage : ContentPage
    {
        static List<ListItem> dataItems = new List<ListItem>
        {
            new ListItem { Title="Clash Of Clan",Description="Online game yang mempunyai genre real time strategy yang sangat populer" },
            new ListItem { Title="Fifa 18",Description="Game sepakbola paling populer di dunia" },
            new ListItem { Title="DOTA", Description="Game RTS paling populer sepanjang masa"},
            new ListItem { Title="Metal Gear Solid", Description="Third person game strategy paling populer"}
        };

        public ListBarangPage()
        {
            InitializeComponent();
        }
    }
}