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
    class TicketService : ITicketService
    {
        private readonly ITicketRepository ticketRepository;


        private readonly IUnitOfWork unitOfWork;

        public TicketService(ITicketRepository ticketRepository, IUnitOfWork unitOfWork)
        {
            this.ticketRepository = ticketRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateTicket(TicketPivot Tickets)
        {
            GEN_TiersContact item = Mapper.Map<TicketPivot, GEN_TiersContact>(Tickets);
            ticketRepository.Add(item);
        }

        public void DeleteTicket(TicketPivot Tickets)
        {
            ticketRepository.Delete(Mapper.Map<TicketPivot, GEN_TiersContact>(Tickets));
        }

        public IEnumerable<TicketPivot> GetALL()
        {
            IEnumerable<GEN_TiersContact> reglement = ticketRepository.GetALL().ToList();

            IEnumerable<TicketPivot> reglementPivots = Mapper.Map<IEnumerable<GEN_TiersContact>, IEnumerable<TicketPivot>>(reglement);
            return reglementPivots;
        }

        public TicketPivot GetTickets(long id)
        {
            var item = ticketRepository.GetById((int)id);
           TicketPivot reglementFacturePivots = Mapper.Map<GEN_TiersContact, TicketPivot>(item);
            return reglementFacturePivots;
        }

        public void SaveTicket()
        {

            unitOfWork.Commit();
        }

        public IEnumerable<TicketPivot> Tickets(string identifged)
        {
            IEnumerable<GEN_TiersContact> motif = ticketRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TicketPivot> reglementFacturePivots = Mapper.Map<IEnumerable<GEN_TiersContact>, IEnumerable<TicketPivot>>(motif);
            return reglementFacturePivots;
        }

        public void UpdateTicket(TicketPivot Tickets)
        {
            ticketRepository.Update(Mapper.Map<TicketPivot, TicketPivot>(Tickets));
        }
    }
}
