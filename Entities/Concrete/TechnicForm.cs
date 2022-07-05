
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TechnicForm:IEntity
    {
        public int  Id { get; set; }
        public string  FormDesc { get; set; }
        public DateTime? FormDate { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSerialNo { get; set; }
        public int FormCode { get; set; }
        public int UserId { get; set; }
        public int FormStatus { get; set; }
        public int FormImageId { get; set; }
        public string PhoneNumber { get; set; }

    }
}
