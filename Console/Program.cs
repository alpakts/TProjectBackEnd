using Business.Concrete;
using Core.Entity.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FormManager manager = new FormManager(new EfFormDal());
            Random rastgele = new Random();
           
            var form1= new Entities.Concrete.TechnicForm
            
            {
                DeviceName = "samsung",
                DeviceSerialNo = "446565645",
                FormCode = rastgele.Next(),
                FormDate = DateTime.Now,
                FormDesc = "asdasd",
            };
            _ = manager.Add(form1);
            var detail=manager.GetFormDetail(form1);
            foreach (var item in detail.Data)
            {
                System.Console.WriteLine(item.FirstName);
            }
            foreach (var item in manager.GetAll().Data)
            {
                System.Console.WriteLine(item.FormDate);
            }
            
            
        }
    }
}
