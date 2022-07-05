using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FormImage:IEntity
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
