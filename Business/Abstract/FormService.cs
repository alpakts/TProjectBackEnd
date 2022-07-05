using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface FormService
    {
        IDataResult<List<TechnicForm>> GetAll();
        IResult Add(TechnicForm entity);
        IDataResult<TechnicForm> GetByFormCode(int formCode);
        IResult Update(TechnicForm entity);
        IResult Delete(TechnicForm entity);
        IDataResult<List<TechnicForm>> GetAllByUserId(int userId);
        IDataResult<List<TechnicForm>> GetAllByStatusIId(int statusId);
    }
}
