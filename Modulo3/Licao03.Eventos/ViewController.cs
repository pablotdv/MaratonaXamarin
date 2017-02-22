using Foundation;
using System;

using UIKit;

namespace Licao03.Eventos
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            btnStart.AccessibilityIdentifier = "myButton";
            btnStart.TouchUpInside += BtnStart_TouchUpInside;
            txtUser.Delegate = new UITextFieldUserValidationDelegate();
            txtPassword.WeakDelegate = this;
        }

        partial void ValueChanged(UITextField sender)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
                txtPassword.Enabled = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        void BtnStart_TouchUpInside(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                txtCode.Enabled = true;
                btnStart.TouchUpInside -= BtnStart_TouchUpInside;
                btnStart.TouchUpInside += (sen, eve) => this.ShowPopup("Hola", "Alerta");

            }

        }

        [Export("textField:shouldChangeCharactersInRange:replacementString:")]
        public bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
        {
            return Validations.ValidateInput(replacementString, Validations.ValidationType.Password);
        }        
    }
}
