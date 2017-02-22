// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Licao03.Eventos
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtCode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUsuario { get; set; }

        [Action ("ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ValueChanged (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnStart != null) {
                btnStart.Dispose ();
                btnStart = null;
            }

            if (txtCode != null) {
                txtCode.Dispose ();
                txtCode = null;
            }

            if (txtPassword != null) {
                txtPassword.Dispose ();
                txtPassword = null;
            }

            if (txtUsuario != null) {
                txtUsuario.Dispose ();
                txtUsuario = null;
            }
        }
    }
}