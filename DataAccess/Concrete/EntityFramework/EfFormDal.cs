using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFormDal : EfEntityRepositoryBase<TechnicForm, TechnicContext>, IFormDal
    {
        public void update( TechnicForm form){
            using (var context = new TechnicContext())
            {
                var forms = context.Forms.Where(f => f.Id == form.Id).FirstOrDefault();
                forms.FormDate = form.FormDate;
                forms.FormDesc = form.FormDesc;
                forms.FormImageId = form.FormImageId;
                forms.FormCode = form.FormCode;
                forms.DeviceName = form.DeviceName;
                forms.DeviceSerialNo = form.DeviceSerialNo;
                forms.Id = form.Id;
                forms.PhoneNumber = form.PhoneNumber;
                forms.FormStatus = form.FormStatus;
                context.SaveChanges();

            }
        }
    }
}
