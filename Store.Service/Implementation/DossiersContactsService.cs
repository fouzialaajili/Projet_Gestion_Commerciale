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
    class DossiersContactsService : IDossiersContactsService
    {
        private readonly IDossiersContactsRepository dossiersContactsRepository;
        private readonly IUnitOfWork unitOfWork;

        public DossiersContactsService(IDossiersContactsRepository dossiersContactsRepository, IUnitOfWork unitOfWork)
        {
            this.dossiersContactsRepository= dossiersContactsRepository;
            this.unitOfWork = unitOfWork;
 }

        public void CreateDossiersContactsPivot(DossiersContactsPivot dossiersContactsPivot)
        {
            GEN_DossiersContacts dossiersContacts = Mapper.Map<DossiersContactsPivot, GEN_DossiersContacts>(dossiersContactsPivot);
            dossiersContactsRepository.Add(dossiersContacts);
        }

        public void DeleteDossiersContactsPivot(DossiersContactsPivot dossiersContacts)
        {
            dossiersContactsRepository.Delete(Mapper.Map<DossiersContactsPivot, GEN_DossiersContacts>(dossiersContacts));

        }

        public IEnumerable<DossiersContactsPivot> GetALL()
        {
            IEnumerable<GEN_DossiersContacts> dossiersContacts = dossiersContactsRepository.GetAll().ToList();
            IEnumerable<DossiersContactsPivot> documentCommercialPivot = Mapper.Map<IEnumerable<GEN_DossiersContacts>, IEnumerable<DossiersContactsPivot>>(dossiersContacts);
            return documentCommercialPivot;
        }

        public DossiersContactsPivot GetDossiersContactsPivot(long id)
        {
            var dossiersContacts= dossiersContactsRepository.GetById((int)id);
            DossiersContactsPivot documentCommercialPivot = Mapper.Map<GEN_DossiersContacts,DossiersContactsPivot > (dossiersContacts);
            return documentCommercialPivot;
        }

        public IEnumerable<DossiersContactsPivot> GetDossiersContactsPivotByCodeDossier(string CodeDossier)
        {
            throw new NotImplementedException();
        }

        public void SaveDossiersContacts()
        {
            unitOfWork.Commit();
        }

        public void UpdateDossiersContactsPivot(DossiersContactsPivot dossiersContacts)
        {

            dossiersContactsRepository.Update(Mapper.Map<DossiersContactsPivot, GEN_DossiersContacts>(dossiersContacts));

        }
    }
}
