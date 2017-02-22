using Foundation;
using System;

using UIKit;

namespace Licao03.Eventos
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }       

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            btnStart.AccessibilityIdentifier = "myButton";
            btnStart.TouchUpInside += BtnStart_TouchUpInside;
            txtUsuario.Delegate = new UITextFieldUserValidationDelegate();
            txtPassword.WeakDelegate = this;            
        }

        
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        partial void ValueChanged(UITextField sender)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
                txtPassword.Enabled = true;
        }

        private void BtnStart_TouchUpInside(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
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