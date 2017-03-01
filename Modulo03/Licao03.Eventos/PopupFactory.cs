using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Licao03.Eventos
{
    public static class PopupFactory
    {

        //https://github.com/HumbertoJaimes
        public static void ShowPopup(this UIViewController controller, string message, string title)
        {
            UIAlertController alert = new UIAlertController();
            alert.Title = title;
            alert.Message = message;
            UIAlertAction positiveAction = UIAlertAction.Create("Ok", UIAlertActionStyle.Default, (obj) => { });
            UIAlertAction negativeAction = UIAlertAction.Create("Cancel", UIAlertActionStyle.Default, (obj) => { });
            alert.AddAction(positiveAction);
            alert.AddAction(negativeAction);
            controller.PresentViewController(alert, true, null);
        }
    }
}
