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
using AutoMapper;
namespace Store.Service.Implementation
{
    class TicketDetailService : ITicketDetailService
    {


        private readonly ITicketDetailRepository ticketDetailRepository;


        private readonly IUnitOfWork unitOfWork;

        public TicketDetailService(ITicketDetailRepository ticketDetailRepository, IUnitOfWork unitOfWork)
        {
            this.ticketDetailRepository = ticketDetailRepository;
            this.unitOfWork = unitOfWork;
        }




        public void CreateTicketDetail(TicketDetailPivot TicketDetail)
        {

            GES_TicketDetail item = Mapper.Map<TicketDetailPivot, GES_TicketDetail>(TicketDetail);
            ticketDetailRepository.Add(item);
        }

        public void DeleteTicketDetail(TicketDetailPivot TicketDetail)
        {
            ticketDetailRepository.Delete(Mapper.Map<TicketDetailPivot, GES_TicketDetail>(TicketDetail));
        }

        public IEnumerable<TicketDetailPivot> GetALL()
        {
            IEnumerable<GES_TicketDetail> reglement = ticketDetailRepository.GetALL().ToList();
            IEnumerable<TicketDetailPivot> reglementPivots = Mapper.Map<IEnumerable<GES_TicketDetail>, IEnumerable<TicketDetailPivot>>(reglement);
            return reglementPivots;
        }

        public TicketDetailPivot GetTicketDetail(long id)
        {
            var item = ticketDetailRepository.GetById((int)id);
            TicketDetailPivot reglementFacturePivots = Mapper.Map<GES_TicketDetail, TicketDetailPivot>(item);
            return reglementFacturePivots;
        }

        public void SaveTicketDetail()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<TicketDetailPivot> TicketDetails(string identifged)
        {
            IEnumerable<GES_TicketDetail> motif = ticketDetailRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TicketDetailPivot> TicketDetailPivots = Mapper.Map<IEnumerable<GES_TicketDetail>, IEnumerable<TicketDetailPivot>>(motif);
            return TicketDetailPivots;
        }

        public void UpdateTicketDetail(TicketDetailPivot TicketDetail)
        {
            ticketDetailRepository.Update(Mapper.Map<TicketDetailPivot, GES_TicketDetail>(TicketDetail));
        }
    }
}
