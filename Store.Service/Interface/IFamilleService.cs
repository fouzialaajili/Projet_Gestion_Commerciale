using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
   public  interface IFamilleService
    {
        IEnumerable<FamillePivot> GetALL();
        FamillePivot GetDossiersPivot(long id);
        IEnumerable<FamillePivot> GetFamillePivotByFamilleCode(string FamilleCode);
        void DeleteFamillePivot(FamillePivot dossiers);
        void UpdateFamillePivot(FamillePivot dossiers);
        void CreateFamillePivot(FamillePivot dossiers);
        void SaveFamille();
    }
}
