// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Licao04
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView Mapa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl Selector { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Visor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIWebView VisorWeb { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Mapa != null) {
                Mapa.Dispose ();
                Mapa = null;
            }

            if (Selector != null) {
                Selector.Dispose ();
                Selector = null;
            }

            if (Visor != null) {
                Visor.Dispose ();
                Visor = null;
            }

            if (VisorWeb != null) {
                VisorWeb.Dispose ();
                VisorWeb = null;
            }
        }
    }
}