using EmailServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Interface
{
    public interface IGetData
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<List<int>> GetDoNotsentbirthday();
    }
}
