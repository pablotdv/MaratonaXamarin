using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestfulCountries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryCell : ContentPage
    {
        public CountryCell()
        {
            InitializeComponent();
        }
    }
}
