﻿using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
  
    public interface ILicenceRepository : IRepository<GES_Licence>
    {
        IEnumerable<GES_Licence> GetALL();
        GES_Licence GetById(long id);
        IEnumerable<GES_Licence> GetItemsByModelLibelle(string identifged);
    }


    public class LicenceRepositoy : RepositoryBase<GES_Licence>, ILicenceRepository
    {
        public LicenceRepositoy(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GES_Licence> GetALL()
        {
            return DbContext.Licences.ToList();
        }

        public GES_Licence GetById(long id)
        {

            var licences = this.DbContext.Licences.Where(c => c.LicenceId == id).SingleOrDefault();

            return licences;
        }

        public IEnumerable<GES_Licence> GetItemsByModelLibelle(string identifged)
        {
            var licences = this.DbContext.Licences.Where(c => c.LicenceRaisonSociale == identifged);

            return licences;
        }
    }
}
