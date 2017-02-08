using Android.App;
using Android.Widget;
using Android.OS;

namespace Licao01
{
    [Activity(Label = "Licao01", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button btnConverter = FindViewById<Button>(Resource.Id.btnConverter);
            EditText txtDolares = FindViewById<EditText>(Resource.Id.txtDoalares);
            EditText txtReais = FindViewById<EditText>(Resource.Id.txtReais);

            double reais, dolares;

            btnConverter.Click += delegate
            {
                try
                {
                    dolares = double.Parse(txtDolares.Text);
                    reais = dolares * 3.25;
                    txtReais.Text = reais.ToString();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            };
        }
    }
}

