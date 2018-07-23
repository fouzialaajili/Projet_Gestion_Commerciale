using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface ITiersContactService
    {
        IEnumerable<TiersContactsPivot> GetALL();
        TiersContactsPivot GetTiersContacts(long id);
        IEnumerable<TiersContactsPivot>TiersContact(string identifged);
        void DeleteTiersContacts(TiersContactsPivot TiersContact);
        void UpdateTiersContacts(TiersContactsPivot TiersContact);
        void CreateTiersContacts(TiersContactsPivot TiersContact);
        void SaveTiersContacts();
    }
}
