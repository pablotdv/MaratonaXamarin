using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Licao02.Storage.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Licao02.iOS.Storage.Implementations;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace Licao02.iOS.Storage.Implementations
{
    public class SQLiteIOS : ISQLite
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