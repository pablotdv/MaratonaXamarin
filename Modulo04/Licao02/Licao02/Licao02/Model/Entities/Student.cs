using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao02.Model.Entities
{
    public class Student : ObservableBaseObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChange(); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChange(); }
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; OnPropertyChange(); }
        }

        private string studentNumber;

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; OnPropertyChange(); }
        }

        private double average;

        public double Average
        {
            get { return average; }
            set { average = value; OnPropertyChange(); }
        }
    }
}
