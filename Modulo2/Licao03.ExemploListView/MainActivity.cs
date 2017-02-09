using Android.App;
using Android.Widget;
using Android.OS;

namespace Licao03.ExemploListView
{
    [Activity(Label = "Licao03.ExemploListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            EmployeeList employeeList = new EmployeeList();
            var employees = employeeList.GetEmployees(20);

            ListView lvEmployees = FindViewById<ListView>(Resource.Id.lvEmployees);

            EmployeeAdapter adapter = new EmployeeAdapter(employees);

            lvEmployees.Adapter = adapter;
        }
    }
}

