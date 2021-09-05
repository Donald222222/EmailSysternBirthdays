using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime employmentStartDate { get; set; }
        public object employmentEndDate { get; set; }
        public string lastNotification { get; set; }
    }
}
