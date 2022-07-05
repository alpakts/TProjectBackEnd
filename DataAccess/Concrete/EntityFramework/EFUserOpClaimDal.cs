using Core.Entity.Concrete;
using Core.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUserOpClaimDal : EfEntityRepositoryBase<UserOperationClaim, TechnicContext>, IUserOpClaimDal
    {
        public void update(UserOperationClaim claim)
        {
            using (var context = new TechnicContext())
            {
                var claims = context.UserOperationClaims.Where(u => u.UserId == claim.UserId).FirstOrDefault();
                claims.UserId = claim.UserId;
                claims.OperationClaimId = claim.OperationClaimId;
                context.SaveChanges();
                
            }
        }
    }
}
