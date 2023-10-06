using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Models
{
    internal class Student : BaseEntity
    {
      public string Name { get; set; }
      public string SurName { get; set; }
      public DateTime Birthday { get; set; }
      
    }
}
