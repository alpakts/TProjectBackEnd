using Core.Utilities.Results;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFormImageService
    {
        IResult Add(IFormFile file, FormImage Image);
        IResult Delete(FormImage carImaImagege);
        IResult Update(IFormFile file, FormImage Image);

        IDataResult<List<FormImage>> GetAll();
        IDataResult<List<FormImage>> GetByFormId(int FormId);
        IDataResult<FormImage> GetByImageId(int imageId);
    }
}
