﻿using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    /*class GedRepository : RepositoryBase<GES_Ged>, IGedRepository
    {
        public GedRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Ged> GetAll()
        {
            return this.DbContext.Geds.ToList();
        }

        public IEnumerable<GES_Ged> GetItemsByModelLibelle(string identifged)
        {
            var geds = this.DbContext.Geds.Where(c => c.GedEntiteName == identifged);

            return geds;
        }

        public GES_Ged GetById(long id)
        {
            var geds = this.DbContext.Geds.Where(c => c.GedId== id).SingleOrDefault();

            return geds;
        }
    }

    public interface IGedRepository : IRepository<GES_Ged>
    {
        IEnumerable<GES_Ged> GetAll();
         GES_Ged GetById(long id);
        IEnumerable<GES_Ged> GetItemsByModelLibelle(string identifged);


    }*/
}
