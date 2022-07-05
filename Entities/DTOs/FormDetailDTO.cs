using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FormDetailDTO:IDTO
    {
        public string FormDesc { get; set; }
        public DateTime FormDate { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSerialNo { get; set; }
        public int FormCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
