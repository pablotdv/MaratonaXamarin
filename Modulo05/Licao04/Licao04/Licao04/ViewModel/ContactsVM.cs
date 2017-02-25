using Licao04.Model.Entities;
using Licao04.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Licao04.ViewModel
{
    public class ContactsVM : ObservableBaseObject
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        private AzureClient _client;
        public Command RefreshCommand { get; set; }
        public Command GenerateContactsCommand { get; set; }
        public Command CleanLocalDataCommand { get; set; }

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }

            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        private bool isBusy;

        public ContactsVM()
        {
            RefreshCommand = new Command(() => Load());
            GenerateContactsCommand = new Command(() => generateContacts());
            CleanLocalDataCommand = new Command(() => cleanLocalData());
            Contacts = new ObservableCollection<Contact>();
            _client = new AzureClient();
        }

        private async Task cleanLocalData()
        {
            await _client.CleanData();
        }

        private void generateContacts()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            string[] names = { "José Luis", "Miguel Ángel", "José Francisco", "Jesús Antonio", "Jorge", "Alberto",
                                "Sofía", "Camila", "Valentina", "Isabella", "Ximena", "Ana"};
            string[] lastNames = { "Hernández", "García", "Martínez", "López", "González", "Méndez", "Castillo", "Corona", "Cruz" };

            Random rdn = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                var contact = new Contact() { Name = $"{names[rdn.Next(0, 12)]} {lastNames[rdn.Next(0, 8)]}" };
                _client.AddContact(contact);
            }

            IsBusy = false;
        }

        public async void Load()
        {
            var result = await _client.GetContacts();

            Contacts.Clear();

            foreach (var item in result)
            {
                Contacts.Add(item);
            }
            IsBusy = false;
        }
    }
}
