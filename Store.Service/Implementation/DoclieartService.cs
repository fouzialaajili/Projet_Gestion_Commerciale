﻿using AutoMapper;
using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Implementation
{
    public class DoclieartService : IDoclieartService
    {
        private readonly IDoclieartRepository doclieRepository;
        private readonly IUnitOfWork unitOfWork;
        public DoclieartService(IDoclieartRepository doclieRepository, IUnitOfWork unitOfWork)
        {
            this.doclieRepository = doclieRepository;
            this.unitOfWork = unitOfWork;

        }

        public void CreateDoclieartPivot(DoclieartPivot doclieart)
        {
            GES_Doclieart docliearts = Mapper.Map<DoclieartPivot, GES_Doclieart>(doclieart);
            doclieRepository.Add(docliearts);
        }

        public void DeleteDoclieartPivot(DoclieartPivot doclieart)
        {
            doclieRepository.Delete(Mapper.Map<DoclieartPivot,GES_Doclieart>(doclieart));
        }

        public IEnumerable<DoclieartPivot> GetALL()
        {
            IEnumerable<GES_Doclieart> doclieartPivots = doclieRepository.GetAll().ToList();
            IEnumerable<DoclieartPivot> DoclieartPivot = Mapper.Map<IEnumerable<GES_Doclieart>, IEnumerable<DoclieartPivot>>(doclieartPivots);
            return DoclieartPivot;
         
        }

        public DoclieartPivot GetDevisesPivot(long id)
        {
            var doclieart= doclieRepository.GetById((int)id);
            DoclieartPivot doclieartPivot = Mapper.Map<GES_Doclieart, DoclieartPivot>(doclieart);
            return doclieartPivot;
        }

        public IEnumerable<DoclieartPivot> GetDoclieartPivotByCode(string DoclieartNomdoc)
        {
            throw new NotImplementedException();
        }

        public void SaveDoclieartPivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateDoclieartPivot(DoclieartPivot doclieart)
        {
            doclieRepository.Update(Mapper.Map<DoclieartPivot, GES_Doclieart>(doclieart));
        }
    }
}
