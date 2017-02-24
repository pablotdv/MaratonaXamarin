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
using Licao02.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Licao02.Droid.Storage.Implementations;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace Licao02.Droid.Storage.Implementations
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            var path = Path.Combine(documentsPath, sqliteFilename);

            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}