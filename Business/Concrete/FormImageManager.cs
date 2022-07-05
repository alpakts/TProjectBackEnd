using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FormImageManager : IFormImageService

    {
        IFormImageDal _formImageDal;
        IFileHelper _fileHelper;

        public FormImageManager(IFormImageDal formImageDal, IFileHelper fileHelper)
        {
            _formImageDal = formImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, FormImage Image)
        {
            //İş kodları
            IResult result = Businessrules.Run(CheckIfCarImageLimit(Image.FormId));
            if (result != null)
            {
                return result;
            }

            Image.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            Image.Date = DateTime.Now;
            _formImageDal.Add(Image);
            return new SuccessResult("Resim Başarıyla Yüklendii");
        }

        public IResult Delete(FormImage Image)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + Image.ImagePath);
            _formImageDal.Delete(Image);
            return new SuccessResult("İlgili aracın ilgili resmi silindi");
        }

        public IDataResult<List<FormImage>> GetAll()
        {
            return new SuccessDataResult<List<FormImage>>(_formImageDal.GetAll());
        }

        public IDataResult<List<FormImage>> GetByFormId(int formId)
        {
            var result = Businessrules.Run(CheckFormImage(formId));
            if (result != null)
            {
                return new ErrorDataResult<List<FormImage>>(GetDefaultImage(formId).Data);
            }
            return new SuccessDataResult<List<FormImage>>(_formImageDal.GetAll(c => c.FormId == formId));
        }

        public IDataResult<FormImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<FormImage>(_formImageDal.Get(f => f.Id == imageId));
        }

        public IResult Update(IFormFile file, FormImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath, PathConstants.ImagesPath + carImage.ImagePath);
            carImage.Date = DateTime.Now;
            _formImageDal.Update(carImage);
            return new SuccessResult("İlgili formun resmi güncellendi!");
        }

        private IResult CheckIfCarImageLimit(int formId)
        {
            var result = _formImageDal.GetAll(f => f.FormId == formId).Count;
            if (result >= 5)
            {
                return new ErrorResult("Bir forma en fazla 5 fotoğraf yüklenebilir!");
            }
            return new SuccessResult();
        }

        private IResult CheckFormImage(int formId)
        {
            var result = _formImageDal.GetAll(f => f.FormId == formId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        private IDataResult<List<FormImage>> GetDefaultImage(int formId)
        {
            List<FormImage> carImage = new List<FormImage>();
            carImage.Add(new FormImage { FormId = formId, Date = DateTime.Now, ImagePath = "wwwroot\\Upload\\DefaultImage.jpg" });
            return new SuccessDataResult<List<FormImage>>(carImage);
        }
    }
}
