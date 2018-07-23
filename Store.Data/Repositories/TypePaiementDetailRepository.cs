﻿using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TypePaiementDetailRepository : RepositoryBase<GEN_TypePaiementDetail>, ITypePaiementDetailRepositoy
    {
        public TypePaiementDetailRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GEN_TypePaiementDetail> GetALL()
        {
            throw new NotImplementedException();
        }

        public GEN_TypePaiementDetail GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GEN_TypePaiementDetail> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }



    public interface ITypePaiementDetailRepositoy : IRepository<GEN_TypePaiementDetail>
    {
        IEnumerable<GEN_TypePaiementDetail> GetALL();
        GEN_TypePaiementDetail GetById(long id);
        IEnumerable<GEN_TypePaiementDetail> GetItemsByModelLibelle(string identifged);

    }


}