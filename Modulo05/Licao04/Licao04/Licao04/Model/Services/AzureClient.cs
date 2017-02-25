using Licao04.Model.Entities;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licao04.Model.Services
{
public class AzureClient
{
    private IMobileServiceClient _client;
    private IMobileServiceSyncTable<Contact> _table;
    private const string serviceUri = "http://{app}.azurewebsites.net/";
    const string dbPath = "contactDb";

    public AzureClient()
    {
        _client = new MobileServiceClient(serviceUri);

        var store = new MobileServiceSQLiteStore(dbPath);
        store.DefineTable<Contact>();
        _client.SyncContext.InitializeAsync(store);

        _table = _client.GetSyncTable<Contact>();
    }

    public async Task<IEnumerable<Contact>> GetContacts()
    {
        var empty = new Contact[0];
        try
        {
            if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
                await SyncAsync();
            return await _table.ToEnumerableAsync();
        }
        catch (Exception)
        {
            return empty;
        }
    }

    public async void AddContact(Contact contact)
    {
        await _table.InsertAsync(contact);
    }

    public async Task SyncAsync()
    {
        ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;

        try
        {
            await _client.SyncContext.PushAsync();

            await _table.PullAsync("allContacts", _table.CreateQuery());
        }
        catch (MobileServicePushFailedException pushEx)
        {
            if (pushEx.PushResult != null)
                syncErrors = pushEx.PushResult.Errors;
        }
    }

    public async Task CleanData ()
    {
        await _table.PurgeAsync("allContacts", _table.CreateQuery(), new System.Threading.CancellationToken());
    }
}
}
