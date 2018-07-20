using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;

namespace Store.Service.Implementation
{
    class LicenceService : ILicenceService
    {
        private readonly ILicenceRepository licenceRepository;
    

        private readonly IUnitOfWork unitOfWork;

        public LicenceService(ILicenceRepository licenceRepository , IUnitOfWork unitOfWork)
        {
            this.licenceRepository = licenceRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateLicence(LicencePivot licence)
        {
            LicencePivot item = Mapper.Map<LicencePivot, GES_Licence>(licence);
            licenceRepository.Add(item);
        }

        public void DeleteLicence(LicencePivot licence)
        {
            licenceRepository.Delete(Mapper.Map<LicencePivot, GES_Licence>(licence));
        }

        public IEnumerable<LicencePivot> GetALL()
        {
            IEnumerable<GES_Licence> licences = licenceRepository.GetALL().ToList();
            IEnumerable<LicencePivot> licencePivots = Mapper.Map<IEnumerable<GES_FournisseurArticle>, IEnumerable<FournisseurArticlePivot>>(licences);
            return licencePivots;
        }

        public LicencePivot GetLicence(long id)
        {
            var item = licenceRepository.GetById((int)id);
            LicencePivot licencePivot = Mapper.Map<GES_FournisseurArticle, FournisseurArticlePivot>(item);
            return licencePivot;
        }

        public IEnumerable<LicencePivot> Licences(string identifged)
        {
            IEnumerable<GES_Licence> licences = licenceRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<LicencePivot> licencesPivots = Mapper.Map<IEnumerable<GES_Licence>, IEnumerable<LicencePivot>>(licences);
            return licencesPivots;
        }

        public void SaveLicence()
        {
            unitOfWork.Commit();
        }

        public void UpdateLicence(LicencePivot licence)
        {
            licenceRepository.Update(Mapper.Map<LicencePivot, GES_Licence>(licence));
        }
    }
}
