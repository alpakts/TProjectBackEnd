
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FormManager : FormService
    {
        IFormDal _formDal;
        
        public FormManager(IFormDal formDal)
        {
            _formDal = formDal;
        }
        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(FormValidator))]
        [CacheRemoveAspect("FormService.Get")]
        public IResult Add(TechnicForm entity)
        {
   

            
            _formDal.Add(entity);
            return new SuccessResult();
        }
        [CacheRemoveAspect("FormService.Get")]
        public IResult Delete(TechnicForm entity)
        {
            _formDal.Delete(entity);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<TechnicForm>> GetAll()
        {
            return new SuccessDataResult<List<TechnicForm>>(_formDal.GetAll());
        }

        
        public IDataResult<TechnicForm> GetByFormCode(int formCode)
        {
            return new SuccessDataResult<TechnicForm>(_formDal.Get(f => f.FormCode == formCode));
        }

        public IDataResult<List<TechnicForm>> GetAllByStatusIId(int statusId)
        {
            return new SuccessDataResult<List<TechnicForm>>(_formDal.GetAll(f=>f.FormStatus==statusId));
        }
        public IDataResult<List<TechnicForm>> GetAllByUserId(int userId)
        {
            return new SuccessDataResult<List<TechnicForm>>(_formDal.GetAll(f=>f.UserId==userId));
        }

        [CacheRemoveAspect("FormService.Get")]
        public IResult Update(TechnicForm entity)
        {
            _formDal.update(entity);
            return new SuccessResult(); 
        }
    }
}
