
using Core.Entity.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        IDataResult<User> GetByUserId(int userID);
        IResult Update(User entity);
        IResult Delete(User entity);
        IResult AddUser(User entity);
    }
}
