using Licao02.Model.Entities;
using Licao02.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Licao02.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new SudentDirectoryVM();

            lvStudents.ItemSelected += LvStudents_ItemSelected;
        }

        private void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if (selectedStudent == null)
                return;

            Navigation.PushAsync(new SelectedStudentDetailPage(selectedStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
