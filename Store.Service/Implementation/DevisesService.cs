using Store.Data.Infrastructure;
using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Implementation
{
   public class DevisesService : IDevisesService
    {
        private readonly IDevisesRepository DevisesRepository;

        private readonly IUnitOfWork unitOfWork;







        /*
         *  private readonly ICodesTvaRepository codesTvaRepository;

        private readonly IUnitOfWork unitOfWork;
        public CodesTVAService(ICodesTvaRepository codesTvaRepository,IUnitOfWork unitOfWork)
        {
            this.codesTvaRepository = codesTvaRepository;
            this.unitOfWork = unitOfWork;

        }
        public void CreateCodesTVAPivot(CodesTVAPivot codesTVAPivot)
        {
            CPT_CodesTVA codesTVA = Mapper.Map<CodesTVAPivot, CPT_CodesTVA>(codesTVAPivot);
            codesTvaRepository.Add(codesTVA);
        }

        public void DeleteCodesTVAPivot(CodesTVAPivot codesTVAPivot)
        {
            codesTvaRepository.Delete(Mapper.Map<CodesTVAPivot, CPT_CodesTVA>(codesTVAPivot));
        }

        public IEnumerable<CodesTVAPivot> GetALL()
        {
            IEnumerable<CPT_CodesTVA> codesTVAPivots = codesTvaRepository.GetAll().ToList();
            IEnumerable<CodesTVAPivot> codesTVAPivot = Mapper.Map<IEnumerable<CPT_CodesTVA>, IEnumerable<CodesTVAPivot>>(codesTVAPivots);
            return codesTVAPivot;
        }

        public CodesTVAPivot GetCodesTVAPivot(long id)
        {
            var item = codesTvaRepository.GetById((int)id);
            CodesTVAPivot codesTVAPivot = Mapper.Map<CPT_CodesTVA, CodesTVAPivot>(item);
            return codesTVAPivot;
        }

        public IEnumerable<CodesTVAPivot> GetCodesTVAPivotByLibelleTaux(string LibelleTaux)
        {
            throw new NotImplementedException();
        }

        public void SaveCodesTVAPivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateCodesTVAPivot(CodesTVAPivot codesTVAPivot)
        {
            codesTvaRepository.Update(Mapper.Map<CodesTVAPivot, CPT_CodesTVA>(codesTVAPivot));
        }
*/
        public void CreateDevisesPivot(DevisesPivot devises)
        {
            throw new NotImplementedException();
        }

        public void DeleteDevisesPivot(DevisesPivot devises)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DevisesPivot> GetALL()
        {
            throw new NotImplementedException();
        }

        public DevisesPivot GetDevisesPivot(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DevisesPivot> GetDevisesPivotByCode(string Code)
        {
            throw new NotImplementedException();
        }

        public void SaveDevisesPivot()
        {
            throw new NotImplementedException();
        }

        public void UpdateDevisesPivot(DevisesPivot devises)
        {
            throw new NotImplementedException();
        }
    }
}
