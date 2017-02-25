using Licao05.Models;
using Licao05.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Licao05
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Country> Countries { get; set; }
        private RestClient _client;

        public Command RefreshCommand { get; set; }

        public MainPage()
        {
            RefreshCommand = new Command(() => Load());
            Countries = new ObservableCollection<Country>();
            _client = new RestClient();

            InitializeComponent();


        }

        public async void Load()
        {
            var result = await _client.GetCountries();

            Countries.Clear();

            foreach (var item in result.OrderBy(a => a.Region).ThenBy(a => a.Name))
            {
                Countries.Add(item);
            }

            IsBusy = false;
        }

    }
}
