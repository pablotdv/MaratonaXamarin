// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Licao05
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEnviar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGuardar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnEnviar != null) {
                btnEnviar.Dispose ();
                btnEnviar = null;
            }

            if (btnGuardar != null) {
                btnGuardar.Dispose ();
                btnGuardar = null;
            }
        }
    }
}