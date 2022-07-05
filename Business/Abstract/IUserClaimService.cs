using Core.Entity.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAlll();
        IResult Update(UserOperationClaim claim);
        IResult Add(UserOperationClaim claim);
        IResult Delete(UserOperationClaim claim);
        IDataResult<UserOperationClaim> GetByClaim(int claim);

        

    }
}
