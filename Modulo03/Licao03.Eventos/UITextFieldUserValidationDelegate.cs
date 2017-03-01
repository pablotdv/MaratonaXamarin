using Foundation;
using UIKit;

namespace Licao03.Eventos
{
    public class UITextFieldUserValidationDelegate : UITextFieldDelegate
    {
        public override bool ShouldChangeCharacters(UITextField textField, NSRange range, string replacementString)
        {
            return Validations.ValidateInput(replacementString, Validations.ValidationType.User);
        }
    }
}