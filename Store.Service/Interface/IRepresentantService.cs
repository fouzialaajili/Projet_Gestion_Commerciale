using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IRepresentantService
    {
        IEnumerable<RepresentantPivot> GetALL();
        RepresentantPivot GetRepresentant(long id);
        IEnumerable<RepresentantPivot> Representants(string identifged);
        void DeleteRepresentant(RepresentantPivot Representant);
        void UpdateRepresentant(RepresentantPivot Representant);
        void CreateRepresentant(RepresentantPivot Representant);
        void SaveRepresentant();

    }
}
