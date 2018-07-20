using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
   public interface IAffaireService
    {
        IEnumerable<AffairePivot> GetALL();
        AffairePivot  GetAffaire(long id);
        IEnumerable<AffairePivot> GetAffairePivotByCode(string Code);
        void DeleteAffairePivot(AffairePivot affaire);
        void UpdateAffairePivot(AffairePivot affaire);
        void CreateAffairePivot(AffairePivot affaire);
        void SaveAffairePivot();
    }
}
