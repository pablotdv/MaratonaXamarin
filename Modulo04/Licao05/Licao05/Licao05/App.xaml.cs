using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Licao05
{
    public partial class App : Application
    {
        private MainPage _mainPage;
        public App()
        {
            _mainPage = new Licao05.MainPage();

            InitializeComponent();

            MainPage = _mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts 
            _mainPage.Load();           
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
