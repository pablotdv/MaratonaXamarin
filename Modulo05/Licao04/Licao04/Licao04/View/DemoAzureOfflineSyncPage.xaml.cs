using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Licao04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoAzureOfflineSyncPage : ContentPage
    {
        public DemoAzureOfflineSyncPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.ContactsVM();
        }
    }
}
