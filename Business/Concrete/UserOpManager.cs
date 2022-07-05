using Business.Abstract;
using Business.Constants;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOpManager : IUserClaimService
    {
        IUserOpClaimDal _claimDal;

        public UserOpManager(IUserOpClaimDal claimDal)
        {
            _claimDal = claimDal;
        }

        public IResult Add(UserOperationClaim claim)
        {
            _claimDal.Add(claim);
            return new SuccessResult(Messages.claimAdded);
        }

        public IResult Delete(UserOperationClaim claim)
        {
            _claimDal.Delete(claim);
            return new SuccessResult(Messages.claimDeleted);
        }

        public IDataResult<List<UserOperationClaim>> GetAlll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_claimDal.GetAll(),Messages.claimBrought);
        }

        public IDataResult<UserOperationClaim> GetByClaim(int claim)
        {
            return new SuccessDataResult<UserOperationClaim>(_claimDal.Get(c => c.OperationClaimId == claim));
        }

        public IResult Update(UserOperationClaim claim)
        {
            _claimDal.update(claim);
            return new SuccessResult(Messages.claimUpdated);
        }
    }
}
