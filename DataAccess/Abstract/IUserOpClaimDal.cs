using Core.DataAccess;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserOpClaimDal:IEntityRepository<UserOperationClaim>
    {
        void update(UserOperationClaim claim);
    }
}
