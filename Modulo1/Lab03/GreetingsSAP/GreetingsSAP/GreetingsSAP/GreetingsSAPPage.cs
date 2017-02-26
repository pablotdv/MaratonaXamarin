using Xamarin.Forms;

namespace GreetingsSAP
{
	public class GreetingsSAPPage : ContentPage
	{
		public GreetingsSAPPage ()
		{
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;
            #if __IOS__
            Padding = new Thickness(0, 20, 0, 0);
            #endif
        }
    }
}
