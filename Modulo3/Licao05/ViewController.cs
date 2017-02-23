using System;
using SQLite;
using UIKit;
using System.IO;

namespace Licao05
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "Base.db3");
            var conn = new SQLiteConnection(path);
            conn.CreateTable<Informacion>();
            btnGuardar.TouchUpInside += delegate
            {
                try
                {
                    var Insertar = new Informacion();
                    Insertar.IngresosMexico = 5555;
                    Insertar.IngresosColombia = 6655;
                    Insertar.EgresosMexico = 3355;
                    Insertar.EgresosColombia = 4455;
                    conn.Insert(Insertar);
                    MessageBox("Guardado Correctamente", "SQLite");
                }
                catch (Exception ex)
                {
                    MessageBox("Error", ex.Message);
                }
            };
            btnEnviar.TouchUpInside += delegate
            {
                UIActionSheet Visor = new UIActionSheet();
                try
                {
                    var clientes = from s in conn.Table<Informacion>()
                                   select s;
                    foreach (var fila in clientes)
                    {
                        Visor.Add((fila.IngresosMexico.ToString()));
                        Visor.Add((fila.IngresosColombia.ToString()));
                        Visor.Add((fila.EgresosMexico.ToString()));
                        Visor.Add((fila.EgresosColombia.ToString()));
                    }
                    Visor.Title = "Informacion de SQLite";
                    Visor.Style = UIActionSheetStyle.BlackOpaque;
                    Visor.ShowInView(this.View);

                }
                catch (Exception ex)
                {
                    MessageBox("Error", ex.Message);
                }
            };
        }

        private void MessageBox(string title, string message)
        {
            using (UIAlertView Alerta = new UIAlertView())
            {
                Alerta.Title = title;
                Alerta.Message = message;
                Alerta.AddButton("OK");
                Alerta.Show();
            }
        }
    }

    public class Informacion
    {
        public double IngresosMexico { get; set; }
        public double IngresosColombia { get; set; }
        public double EgresosMexico { get; set; }
        public double EgresosColombia { get; set; }
    }
}