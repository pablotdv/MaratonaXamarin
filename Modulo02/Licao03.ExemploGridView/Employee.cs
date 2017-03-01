using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Licao03.ExemploGridView
{
    public class Employee
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string position;
        public string Position { get { return position; } set { position = value; } }

        private string email;
        public string Email { get { return email; } set { email = value; } }

        public Employee(string name, string position, string email)
        {
            Name = name;
            Position = position;
            Email = email;
        }
    }

    public class EmployeeList
    {
        public Employee[] GetEmployees(int number)
        {
            Employee[] employees = new Employee[number];

            String[] positions = { "Supervisor", "Operador", "Gerente", "Director" };
            Random rdn = new Random();

            for(int i = 0; i< number; i++)
            {
                var name = Guid.NewGuid().ToString().Substring(0, 10);

                var employee = new Employee(name, positions[rdn.Next(0,3)], name+"@teste.com");

                employees[i] = employee;
                
            }

            return employees;
        }
    }
}