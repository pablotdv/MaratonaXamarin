using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;

namespace Licao04.ExemploSQLite
{

    [Activity(Label = "VistaCapital")]
    public class VistaCapital : Activity
    {
        double defaultValue;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.VistaCapital);
                                  
            
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "Base.db3");
            var conn = new SQLiteConnection(path);

            var elementos = from s in conn.Table<Informacion>()
                            select s;

            ListView lvInformaciones = FindViewById<ListView>(Resource.Id.lvInformaciones);

            InformacionAdapter adapter = new InformacionAdapter(elementos.ToArray());

            lvInformaciones.Adapter = adapter;
            
        }
    }
}