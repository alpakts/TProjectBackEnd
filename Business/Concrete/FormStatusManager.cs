using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FormStatusManager : IFormStatusService
    {
       IFormStatusDal _statusDal;

        public FormStatusManager(IFormStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IDataResult<List<FormStatus>> GetAll()
        {
            return new SuccessDataResult<List<FormStatus>>(_statusDal.GetAll());
        }
        public IDataResult<FormStatus> GetById(int Id)
        {
            return new SuccessDataResult<FormStatus>(_statusDal.Get(f => f.Id == Id));
        }
    }
}
