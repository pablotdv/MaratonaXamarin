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
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();

            ListViewCats.ItemSelected += ListViewCats_ItemSelected;
        }

        private async void ListViewCats_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedCat = e.SelectedItem as Models.Cat;
            if (SelectedCat != null)
            {
                await Navigation.PushAsync(new Views.DetailsPage(SelectedCat));
                ListViewCats.SelectedItem = null;
            }
        }
    }
}
