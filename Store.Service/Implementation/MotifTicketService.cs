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

namespace Store.Service.Implementation
{
    class MotifTicketService : IMotifTicketService
    {
        private readonly IMotifTicketRepository motifTicketRepository;


        private readonly IUnitOfWork unitOfWork;

        public MotifTicketService(IMotifTicketRepository motifTicketRepository, IUnitOfWork unitOfWork)
        {
            this.motifTicketRepository = motifTicketRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateMotifTicket(MotifTicketPivot Motif)
        {
            MotifPivot item = Mapper.Map<MotifTicketPivot, GES_MotifTicket>(Motif);
            motifTicketRepository.Add(item);
        }

        public void DeleteMotifTicket(MotifTicketPivot Motif)
        {
            motifTicketRepository.Delete(Mapper.Map<MotifTicketPivot, GES_MotifTicket>(Motif));
        }

        public IEnumerable<MotifTicketPivot> GetALL()
        {
            IEnumerable<GES_MotifTicket> motif = motifTicketRepository.GetALL().ToList();
            IEnumerable<MotifTicketPivot> motifPivots = Mapper.Map<IEnumerable<GES_MotifTicket>, IEnumerable<MotifTicketPivot>>(motif);
            return motifPivots;
        }

        public MotifTicketPivot GetMotifTickes(long id)
        {
            var item = motifTicketRepository.GetById((int)id);
            MotifPivot motifPivot = Mapper.Map<GES_MotifTicket, MotifTicketPivot>(item);
            return motifPivot;
        }

        public IEnumerable<MotifTicketPivot> MotifTickets(string identifged)
        {
            IEnumerable<GES_MotifTicket> motif = motifTicketRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<MotifTicketPivot> motifsPivots = Mapper.Map<IEnumerable<GES_MotifTicket>, IEnumerable<MotifTicketPivot>>(motif);
            return motifsPivots;
        }

        public void SaveMotif()
        {
            unitOfWork.Commit();
        }

        public void UpdateMotifTicket(MotifTicketPivot Motif)
        {
            motifTicketRepository.Update(Mapper.Map<MotifTicketPivot, GES_MotifTicket>(Motif));
        }
    }
}
