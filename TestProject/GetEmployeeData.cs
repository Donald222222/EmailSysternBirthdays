using EmailServices;
using EmailServices.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
   public  class GetEmployeeData
    {
        [Fact]
        public async Task Get_Raw_Async()
        {
            Startup don = new Startup();

            var serviceProvider = don.Configurservice();

            var service = serviceProvider.GetRequiredService<IGetData>();

            var tasks = await service.GetEmployeesAsync();

            Assert.NotEmpty(tasks);


        }
    }
}
