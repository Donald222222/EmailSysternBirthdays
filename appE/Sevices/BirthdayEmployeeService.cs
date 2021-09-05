using EmailServices.Interface;
using EmailServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Sevices
{
    public class BirthdayEmployeeService : IEmployeeBirthday
    {
        private readonly IGetData _birthday;

        public BirthdayEmployeeService(IGetData birthday)
        {
            _birthday = birthday;
        }
        public async  Task<List<Employee>> GetEmployeeBirthday()
        {

          
             var dontsentemail = await _birthday.GetDoNotsentbirthday();
             var  employee = await _birthday.GetEmployeesAsync();

            

            foreach (Employee i in employee)
            {
                if (dontsentemail.Contains(i.id))
                {
                    employee.Remove(i);
                    break;
                   
                }

            }

            // sort he date of a birthday.
            DateTime today = new();
            foreach (Employee i in employee)
            {
             
                if ((i.dateOfBirth.Day != today.Day)
                    && (i.dateOfBirth.Month != today.Month)
                   && (i.employmentEndDate != null)
                   &&(i.employmentStartDate > today)) 
                {
                    employee.Remove(i);
                }



            }
            return employee;
        }
    }
    
}
