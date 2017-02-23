using Licao02.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Licao02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedStudentDetailPage : ContentPage
    {
        public SelectedStudentDetailPage(Student student)
        {
            InitializeComponent();
            this.BindingContext = student;
        }
    }
}
