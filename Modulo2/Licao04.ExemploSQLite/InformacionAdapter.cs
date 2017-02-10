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

namespace Licao04.ExemploSQLite
{
    public class InformacionAdapter : BaseAdapter<Informacion>
    {
        Informacion[] data;
        public InformacionAdapter(Informacion[] data)
        {
            this.data = data;
        }
        public override Informacion this[int position]
        {
            get
            {
                return data[position];
            }
        }

        public override int Count
        {
            get
            {
                return data.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.InformacionItem, parent, false);

            var txvIngresosMexico = view.FindViewById<TextView>(Resource.Id.txvIngresosMexico);
            var txvEgresosMexico = view.FindViewById<TextView>(Resource.Id.txvEgresosMexico);
            var txvCapitalMexico = view.FindViewById<TextView>(Resource.Id.txvCapitalMexico);
            var txvIngresosColombia = view.FindViewById<TextView>(Resource.Id.txvIngresosColombia);
            var txvEgresosColombia = view.FindViewById<TextView>(Resource.Id.txvEgresosColombia);
            var txvCapitalColombia = view.FindViewById<TextView>(Resource.Id.txvCapitalColombia);


            txvIngresosMexico.Text = data[position].IngresosMexico.ToString();
            txvEgresosMexico.Text = data[position].EgresosMexico.ToString();
            txvCapitalMexico.Text = data[position].CapitalMexico.ToString();

            txvIngresosColombia.Text = data[position].IngresosColombia.ToString();
            txvEgresosColombia.Text = data[position].EgresosColombia.ToString();
            txvCapitalColombia.Text = data[position].CapitalColombia.ToString();

            return view;
        }
    }
}