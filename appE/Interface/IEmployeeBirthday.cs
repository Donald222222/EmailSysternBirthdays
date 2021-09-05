using EmailServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Interface
{
    public interface IEmployeeBirthday
    {
         Task<List<Employee>> GetEmployeeBirthday();
    }
}
