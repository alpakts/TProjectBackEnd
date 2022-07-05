using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFormImageDal : EfEntityRepositoryBase<FormImage, TechnicContext>, IFormImageDal
    {
    }
}
