using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;

            //Device.OnPlatform(iOS:() =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //});

            //MyLabel.HorizontalOptions = LayoutOptions.Center;
            //MyLabel.VerticalOptions = LayoutOptions.Center;            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;
        }
    }
}
