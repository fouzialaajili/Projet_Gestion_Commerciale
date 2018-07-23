﻿using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Service.Implementation
{
    class NumerotationService : INumerotationService
    {


        private readonly INumerotationRepository numerotationRepository;


        private readonly IUnitOfWork unitOfWork;

        public NumerotationService(INumerotationRepository numerotationRepository, IUnitOfWork unitOfWork)
        {
            this.numerotationRepository = numerotationRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateNumerotation(NumerotationPivot numerotation)
        {

            GES_Numerotation item = Mapper.Map<NumerotationPivot, GES_Numerotation>(numerotation);
            numerotationRepository.Add(item);
        }

        public void DeleteNumerotation(NumerotationPivot numerotation)
        {
            numerotationRepository.Delete(Mapper.Map<NumerationPivot, GES_Numerotation>(numerotation));
        }

        public IEnumerable<NumerotationPivot> GetALL()
        {
            IEnumerable<GES_Numerotation> numerotation= numerotationRepository.GetALL().ToList();
            IEnumerable<NomenclaturePivot> numerotationPivots = Mapper.Map<IEnumerable<GES_Numerotation>, IEnumerable<NumerationPivot>>(numerotation);
            return numerotationPivots;
        }

        public NumerotationPivot GetNumerotation(long id)
        {
            var item = numerotationRepository.GetById((int)id);
            NumerationPivot numerotationPivot = Mapper.Map<GES_Numerotation, NumerationPivot>(item);
            return numerotationPivot;
        }

        public IEnumerable<NumerotationPivot> Numerotations(string identifged)
        {
            IEnumerable<GES_Numerotation> numerotation = numerotationRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<NumerationPivot> numerotationPivots = Mapper.Map<IEnumerable<GES_Numerotation>, IEnumerable<NumerationPivot>>(numerotation);
            return numerotationPivots;
        }

        public void SaveMotif()
        {
            unitOfWork.Commit();
        }

        public void UpdateNumerotation(NumerotationPivot numerotation)
        {
            numerotationRepository.Update(Mapper.Map<NumerationPivot, GES_Numerotation>(numerotation));
        }
    }
}
