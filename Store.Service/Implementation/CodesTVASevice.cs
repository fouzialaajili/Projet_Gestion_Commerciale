using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    
   

    /*public class CodesTVAService : ICodesTVAService
    {
        private readonly ICodesTvaRepository codesTvaRepository;
        private readonly ISocieteRepository dossieRepository;
        private readonly IUnitOfWork unitOfWork;

        public CodesTVAService(ICodesTvaRepository codesTvaRepository, ISocieteRepository dossieRepository, IUnitOfWork unitOfWork)
        {
            this.codesTvaRepository = codesTvaRepository;
            this.dossieRepository = dossieRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members


       public IEnumerable<codesTvaRepository> GetCategoryGadgets(string categoryName, string gadgetName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Gadgets.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower().Trim()));
        }
       
       

       

        public IEnumerable<CPT_CodesTVA> GetCodesTVAs()
        {
            var codesTvas = codesTvaRepository.GetAll();
            return codesTvas;
        }

        public IEnumerable<CPT_CodesTVA> GetDossiersGetCodesTVAs(string DossierName, string CodesTVAName = null)
        {
            throw new NotImplementedException();
        }

        public CPT_CodesTVA GetCPT_CodesTVA(int id)
        {
            var codesTva = codesTvaRepository.GetById(id);
            return codesTva;
        }

        public void CreateCPT_CodesTVA(CPT_CodesTVA codesTVA)
        {
            codesTvaRepository.Add(codesTVA);
        }

        public void SaveCPT_CodesTVA()
        {
            unitOfWork.Commit();
        }

        public void DeleteCPT_CodesTVA(CPT_CodesTVA codesTVA)
        {
            throw new NotImplementedException();
        }

        public void UpdateCPT_CodesTVA(CPT_CodesTVA codesTVA)
        {
            throw new NotImplementedException();
        }

        #endregion

    }*/
}
