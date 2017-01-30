using System;
using Android.App;
using Android.Widget;
using Android.OS;
using EnviarCorreo.Forms.Classes;

namespace EnviarCorreo.Nativo
{
    [Activity(Label = "EnviarCorreo.Nativo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            button = FindViewById<Button>(Resource.Id.btnReportar);
            button.Click += btnReportar_Click;
        }

        private async void btnReportar_Click(object sender, EventArgs e)
        {
            ServiceHelper serviceHelper = new ServiceHelper();
            await serviceHelper.InsertarEntidad("maratona@microsoft.com", "Acompanhando a Maratona da cidade de [ESCREVA O NOME DA SUA CIDADE]");
            button.Text = "Teste enviado";
        }
    }
}

