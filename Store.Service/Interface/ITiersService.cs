using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    interface ITiersService
    {
        IEnumerable<TiersPivot> GetALL();
        TiersPivot GetTiers(long id);
        IEnumerable<TiersPivot> Tiers(string identifged);
        void DeleteTiers(TiersPivot Tiers);
        void UpdateTiers(TiersPivot Tiers);
        void CreateTiers(TiersPivot Tiers);
        void SaveTiers();
    }
}
