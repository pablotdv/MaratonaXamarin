using Licao02.Model.Entities;
using Licao02.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Licao02.ViewModel
{    

    public class SudentDirectoryVM : Licao02.Model.Entities.ObservableBaseObject
    {
        public ObservableCollection<Student> Students { get; set; }

        private bool isBusy;

        public Command LoadDirectoryCommand { get; set; }

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }

            set
            {
                isBusy = value;
                OnPropertyChange();
            }
        }

        public SudentDirectoryVM()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        private async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                await Task.Delay(300);

                var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();

                foreach(var student in loadedDirectory.Students)
                {
                    Students.Add(student);
                }

                IsBusy = false;
            }
        }
    }
}
