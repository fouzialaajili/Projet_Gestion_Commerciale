using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IDocumentCommercialDetailSerieRepository : IRepository<GES_DocumentCommercialDetailSerie>
    {

    }


    public class DocumentCommercialDetailSerieRepository : RepositoryBase<GES_DocumentCommercialDetailSerie>, IDocumentCommercialDetailSerieRepository
    {
        public DocumentCommercialDetailSerieRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
