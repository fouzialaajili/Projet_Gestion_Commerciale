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
        IEnumerable<LicencePivot> GetALL();
        LicencePivot GetLicence(long id);
        IEnumerable<LicencePivot> Licences(string identifged);
        void DeleteLicence(LicencePivot licence);
        void UpdateLicence(LicencePivot licence);
        void CreateLicence(LicencePivot licence);
        void SaveLicence();
    }
}
