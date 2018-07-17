using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Store.Data.Repositories
{
    class FichetiersContactRepository:RepositoryBase<Categorie>, IFichierContactRepository
    {
        public FichetiersContactRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public void Add(FichetiersContact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<FichetiersContact, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(FichetiersContact entity)
        {
            throw new NotImplementedException();
        }

        public FichetiersContact Get(Expression<Func<FichetiersContact, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FichetiersContact> GetMany(Expression<Func<FichetiersContact, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(FichetiersContact entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<FichetiersContact> IRepository<FichetiersContact>.GetAll()
        {
            throw new NotImplementedException();
        }

        FichetiersContact IRepository<FichetiersContact>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        /* public FichetiersContact GetCategoryByName(string ContactName)
         {
             var category = this.DbContext.FichetiersContacts.Where(c => c.FichetiersContactNom == ContactName).FirstOrDefault();

             return category;
         }

         public override void Update(FichetiersContact  entity)
         {
             entity.DateUpdated = DateTime.Now;
             base.Update(entity);
         }*/
    }
 
    public interface IFichierContactRepository : IRepository<FichetiersContact>
    {
        //FichetiersContact GetCategoryByName(string categoryName);
    }
}
