using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
  
    public interface IDocumentCommercialDetailRepository : IRepository<GES_DocumentCommercialDetail>
    {

    }


    public class DocumentCommercialDetailRepository : RepositoryBase<GES_DocumentCommercialDetail>, IDocumentCommercialDetailRepository
    {
        public DocumentCommercialDetailRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
