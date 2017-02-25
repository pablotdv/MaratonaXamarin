using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        Models.Cat SelectedCat;
        public DetailsPage(Models.Cat selectedCat)
        {
            InitializeComponent();
            this.SelectedCat = selectedCat;
            BindingContext = this.SelectedCat;
            ButtonWebSite.Clicked += ButtonWebSite_Clicked;
        }

        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedCat.WebSite.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedCat.WebSite));
            }
        }
    }
}
