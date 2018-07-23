using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IOpportuniteService
    {
        IEnumerable<OpportunitePivot> GetALL();
        OpportunitePivot Getopportunite(long id);
        IEnumerable<OpportunitePivot> opportunites(string identifged);
        void DeleteOpportunite(OpportunitePivot opportunite);
        void UpdateOpportunite(OpportunitePivot opportunite);
        void CreateOpportunite(OpportunitePivot opportunite);
        void SaveOpportunite();
    }
}
