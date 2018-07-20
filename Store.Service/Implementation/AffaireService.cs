using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    interface AffaireService
    {
        IEnumerable<GES_Affaire> GetAffaires();
        GES_Affaire GetAffaire(long id);
        void CreateAffaire(GES_Affaire affaire);
        void SaveAffaire();
        IEnumerable<GES_Affaire> GetModelItems(string ModelLibelle);
        IEnumerable<GES_Affaire> GetItemsByModelLibelle(string modelLibelle);
        void DeleteAffaire(GES_Affaire item);
        void UpdateAffaire(GES_Affaire item);
    }
    
}
