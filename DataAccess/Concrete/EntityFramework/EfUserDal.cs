using Core.Entity.Concrete;
using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TechnicContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new TechnicContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, OperationName = operationClaim.OperationName };
                return result.ToList();

            }
        }
        public void update(User user){
            using (var context= new TechnicContext())
            {
                var users = context.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                users.Id=user.Id;
                users.Email=user.Email;
                users.FirstName=user.FirstName;
                users.LastName=user.LastName;
                users.FormId=user.FormId;
                context.SaveChanges();
            }
        }
    }
}
