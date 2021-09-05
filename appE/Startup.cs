using EmailServices.Data;
using EmailServices.Interface;
using EmailServices.Sevices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices
{
    public class Startup
    {
        public IServiceProvider Configurservice()
        {
            var Provider = new ServiceCollection()
                  .AddScoped<IGetData, GetData>()
                  .AddTransient<IEmployeeBirthday, BirthdayEmployeeService>()
                  .AddTransient<ISentEmail, EmailService>()

                  .BuildServiceProvider();



            return Provider;

        }
    }
}
