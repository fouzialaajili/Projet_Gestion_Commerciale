using AutoMapper;
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
    class DossiersService : IDossiersService
    {
        private readonly IDossiersRepository dossiersRepository;
        private readonly IUnitOfWork unitOfWork;
        public DossiersService(IDossiersRepository dossiersRepository, IUnitOfWork unitOfWork)
        {
            this.dossiersRepository = dossiersRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateDossiersContactsPivot(DossiersPivot dossiersPivot)
        {
            GEN_Dossiers dossiers = Mapper.Map<DossiersPivot, GEN_Dossiers>(dossiersPivot);
            dossiersRepository.Add(dossiers);
        }

        public void DeleteDossiersPivot(DossiersPivot dossiersPivot)
        {
            dossiersRepository.Delete(Mapper.Map<DossiersPivot, GEN_Dossiers>(dossiersPivot));

        }

        public IEnumerable<DossiersPivot> GetALL()
        {
            IEnumerable<GEN_Dossiers> dossiers = dossiersRepository.GetAll().ToList();
            IEnumerable<DossiersPivot> dossiersPivot = Mapper.Map<IEnumerable<GEN_Dossiers>, IEnumerable<DossiersPivot>>(dossiers);
            return dossiersPivot;
        }

        public DossiersPivot GetDossiersPivot(long id)
        {
            var dossiers = dossiersRepository.GetById((int)id);
            DossiersPivot dossiersPivot = Mapper.Map<GEN_Dossiers, DossiersPivot>(dossiers);
            return dossiersPivot;
        }

        public IEnumerable<DossiersPivot> GetDossiersPivotByNom(string Nom)
        {
        
            throw new NotImplementedException();
    }
        public void SaveDossiers()
        {
            unitOfWork.Commit();
        }

        public void UpdateDossiersContactsPivot(DossiersPivot dossiers)
        {
            dossiersRepository.Update(Mapper.Map<DossiersPivot, GEN_Dossiers>(dossiers));

        }
    }
}
