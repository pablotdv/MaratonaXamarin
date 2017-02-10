using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;
using System.IO;
using System;
using Android.Content;

namespace Licao04.ExemploSQLite
{
    [Activity(Label = "Licao04.ExemploSQLite", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        double IngresosM, IngresosC, EgresosM, EgresosC, CapitalM, CapitalC;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "Base.db3");
            var conn = new SQLiteConnection(path);

            conn.CreateTable<Informacion>();

            Button btnCalcular = FindViewById<Button>(Resource.Id.btncalcular);
            EditText txtIngresosM = FindViewById<EditText>(Resource.Id.txtingresosM);
            EditText txtIngresosC = FindViewById<EditText>(Resource.Id.txtingresosC);
            EditText txtEgresosM = FindViewById<EditText>(Resource.Id.txtegresosM);
            EditText txtEgresosC = FindViewById<EditText>(Resource.Id.txtegresosC);

            btnCalcular.Click += delegate
            {
                try
                {
                    IngresosM = double.Parse(txtIngresosM.Text);
                    IngresosC = double.Parse(txtIngresosC.Text);
                    EgresosM = double.Parse(txtEgresosM.Text);
                    EgresosC = double.Parse(txtEgresosC.Text);

                    CapitalM = IngresosM - EgresosM;
                    CapitalC = IngresosC - EgresosC;

                    var Insertar = new Informacion()
                    {
                        IngresosMexico = IngresosM,
                        IngresosColombia = IngresosC,
                        EgresosMexico = EgresosM,
                        EgresosColombia = EgresosC
                    };

                    conn.Insert(Insertar);

                    Toast.MakeText(this, "Guardado en SQLite", ToastLength.Long).Show();

                    Cargar();

                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            };
        }

        public void Cargar()
        {
            Intent objIntent = new Intent(this, typeof(VistaCapital));
            objIntent.PutExtra("CapitalM", CapitalM);
            objIntent.PutExtra("CapitalC", CapitalC);
            StartActivity(objIntent);
        }
    }

    public class Informacion
    {
        public double IngresosMexico { get; set; }
        public double IngresosColombia { get; set; }
        public double EgresosMexico { get; set; }
        public double EgresosColombia { get; set; }
        public double CapitalMexico { get { return IngresosMexico - EgresosMexico; } }
        public double CapitalColombia { get { return IngresosColombia - EgresosColombia; } }
    }
}

