using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface ILicenceService
    {
        IEnumerable<GES_Licence> GetALL();
        GES_Licence GetLicence(long id);
        IEnumerable<GES_Licence> Licences(string identifged);
        void DeleteLicence(LicencePivot ged);
        void UpdateLicence(LicencePivot ged);
        void CreateLicence(LicencePivot ged);
        void SaveLicence();
    }
}
