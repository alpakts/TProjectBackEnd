using Core.DataAccess;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // operation claim ve user operation claim data acces ve business katmanalrını yazıcam
    public interface IFormDal:IEntityRepository<TechnicForm>
    {
        void update( TechnicForm form);
    }
}
