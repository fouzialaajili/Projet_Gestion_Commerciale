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
    public class DocumentCommercialService : IDocumentCommercialService
    {
        private readonly IDocumentCommercialRepository documentCommercialRepository;
        private readonly IUnitOfWork unitOfWork;
        public DocumentCommercialService(IDocumentCommercialRepository documentCommercialRepository, IUnitOfWork unitOfWork)
        {
            this.documentCommercialRepository = documentCommercialRepository;
            this.unitOfWork = unitOfWork;

        }
        



        /*
     private readonly IDoclieRepository doclieRepository;
        private readonly IUnitOfWork unitOfWork;
        public DoclieService(IDoclieRepository doclieRepository, IUnitOfWork unitOfWork)
        {
            this.doclieRepository = doclieRepository;
            this.unitOfWork = unitOfWork;

        }
public void CreateDocliePivot(DocliePivot doclie)
        {
            GES_Doclie doclies = Mapper.Map<DocliePivot, GES_Doclie>(doclie);
            doclieRepository.Add(doclies);
        }

        public void DeleteDocliePivot(DocliePivot doclie)
        {
            doclieRepository.Delete(Mapper.Map<DocliePivot, GES_Doclie>(doclie));
        }

        public IEnumerable<DocliePivot> GetALL()
        {
            IEnumerable<GES_Doclie> doclieartPivots = doclieRepository.GetAll().ToList();
            IEnumerable<DocliePivot> docliePivot = Mapper.Map<IEnumerable<GES_Doclie>, IEnumerable<DocliePivot>>(doclieartPivots);
            return docliePivot;
        }

        public DocliePivot GetDocliePivot(long id)
        {
            var doclie = doclieRepository.GetById((int)id);
            DocliePivot docliePivot = Mapper.Map<GES_Doclie, DocliePivot>(doclie);
            return docliePivot;
        }

        public IEnumerable<DocliePivot> GetDocliePivotByCode(string DoclieartNomdoc)
        {
            throw new NotImplementedException();
        }

        public void SaveDocliePivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateDocliePivot(DocliePivot doclie)
        {
            doclieRepository.Update(Mapper.Map<DocliePivot, GES_Doclie>(doclie));
        }
         */
        public void CreateDocumentCommercialPivot(DocumentCommercialPivot documentCommercial)
        {
            GES_DocumentCommercial doclies = Mapper.Map<DocumentCommercialPivot, GES_DocumentCommercial>(documentCommercial);
            documentCommercialRepository.Add(doclies);
        }

        public void DeleteDocumentCommercialPivot(DocumentCommercialPivot documentCommercial)
        {
            documentCommercialRepository.Delete(Mapper.Map<DocumentCommercialPivot, GES_DocumentCommercial>(documentCommercial));
        }

        public IEnumerable<DocumentCommercialPivot> GetALL()
        {
            IEnumerable<GES_DocumentCommercial> documentCommercial = documentCommercialRepository.GetAll().ToList();
            IEnumerable<DocumentCommercialPivot> documentCommercialPivot = Mapper.Map<IEnumerable<GES_DocumentCommercial>, IEnumerable<DocumentCommercialPivot>>(documentCommercial);
            return documentCommercialPivot;
        }

        public DocumentCommercialPivot GetDocumentCommercialPivot(long id)
        {
            var documentCommercial = documentCommercialRepository.GetById((int)id);
            DocumentCommercialPivot documentCommercialPivot = Mapper.Map<GES_DocumentCommercial, DocumentCommercialPivot >(documentCommercial);
            return documentCommercialPivot;
        }

        public void SaveDocumentCommercial()
        {
            /// throw new NotImplementedException();
            unitOfWork.Commit();
        }

        public void UpdateDocumentCommercialPivot(DocumentCommercialPivot documentCommercial)
        {
            documentCommercialRepository.Update(Mapper.Map<DocumentCommercialPivot, GES_DocumentCommercial>(documentCommercial));
            
        }
    }
}
