using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Licao04.Model.Entities
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public ObservableBaseObject()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate {

        };

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
