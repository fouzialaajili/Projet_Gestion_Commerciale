using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Service
{
    class TiersContactsService : ITiersContactService
    {
        private readonly ITiersContactRepository tiersContactsRepository;


        private readonly IUnitOfWork unitOfWork;

        public TiersContactsService(ITiersContactRepository tiersContactsRepository, IUnitOfWork unitOfWork)
        {
            this.tiersContactsRepository = tiersContactsRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateTiersContacts(TiersContactsPivot TiersContact)
        {
            GEN_TiersContacts item = Mapper.Map<TiersContactsPivot, GES_TiersContacts>(TiersContact);
            tiersContactsRepository.Add(item);
        }

        public void DeleteTiersContacts(TiersContactsPivot TiersContact)
        {

            tiersContactsRepository.Delete(Mapper.Map<TiersContactsPivot, GES_TicketDetail>(TiersContact));
        }

        public IEnumerable<TiersContactsPivot> GetALL()
        {
            IEnumerable<GEN_TiersContacts> motif = tiersContactsRepository.GetALL().ToList();
            IEnumerable<TiersContactsPivot> motifPivots = Mapper.Map<IEnumerable<GEN_TiersContacts>, IEnumerable<TiersContactsPivot>>(motif);
            return motifPivots;
        }

        public TiersContactsPivot GetTiersContacts(long id)
        {
            var item = tiersContactsRepository.GetById((int)id);
            TiersContactsPivot  motifPivot = Mapper.Map<GES_TiersContacts, TiersContactsPivot>(item);
            return motifPivot;
        }

        public void SaveTiersContacts()
        {

            unitOfWork.Commit();
        }

        public IEnumerable<TiersContactsPivot> TiersContact(string identifged)
        {
            IEnumerable<GEN_TiersContacts> motif = tiersContactsRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TiersContactsPivot> motifsPivots = Mapper.Map<IEnumerable<GEN_TiersContacts>, IEnumerable<TiersContactsPivot>>(motif);
            return motifsPivots;
        }

        public void UpdateTiersContacts(TiersContactsPivot TiersContact)
        {
           tiersContactsRepository.Update(Mapper.Map<TiersContactsPivot, GES_TiersContacts>(TiersContact));
        }
    }
}
