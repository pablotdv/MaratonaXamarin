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

namespace Licao03.ExemploListView
{
    public class EmployeeAdapter : BaseAdapter<Employee>
    {
        private Employee[] data;

        public EmployeeAdapter(Employee[] data)
        {
            this.data = data;
        }
        public override Employee this[int position]
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
            var view = inflater.Inflate(Resource.Layout.EmployeeItem, parent, false);

            var txvName = view.FindViewById<TextView>(Resource.Id.txvName);
            var txvEmail = view.FindViewById<TextView>(Resource.Id.txvEmail);

            txvName.Text = data[position].Name;
            txvEmail.Text = data[position].Email;

            return view;
        }
    }
}