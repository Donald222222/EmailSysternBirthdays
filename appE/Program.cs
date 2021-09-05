using EmailServices;
using EmailServices.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace appE
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup start = new Startup();
            var container = start.Configurservice();
            var EmployeeData = container.GetRequiredService<IGetData>();
            var birthdayEmployee = container.GetRequiredService<IEmployeeBirthday>();
            var EmailSevices = container.GetRequiredService<ISentEmail>();

            EmployeeData.GetEmployeesAsync();
            birthdayEmployee.GetEmployeeBirthday();
            EmailSevices.Birthdaywishes();
            EmployeeData.GetDoNotsentbirthday();
        }
    }
    
}
