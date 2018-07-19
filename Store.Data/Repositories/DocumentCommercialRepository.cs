using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    
    public interface IDocumentCommercialRepository : IRepository<GES_DocumentCommercial>
    {

    }


    public class DocumentCommercialRepository : RepositoryBase<GES_DocumentCommercial>, IDocumentCommercialRepository
    {
        public DocumentCommercialRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }

}
