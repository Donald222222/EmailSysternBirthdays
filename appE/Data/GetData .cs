using EmailServices.Interface;
using EmailServices.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.Data
{
    public class GetData : IGetData
    {
        private const string BaseUrl2 = "https://interview-assessment-1.realmdigital.co.za/do-not-send-birthday-wishes";
        private const string BaseUrl = "https://interview-assessment-1.realmdigital.co.za/employees";
        
        readonly HttpClient client = new HttpClient();

        
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var httpResponse = await client.GetAsync(BaseUrl);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<List<Employee>>(content);

            return tasks;
        }
        public async Task<List<int>> GetDoNotsentbirthday()
        {
           var httpResponse = await client.GetAsync($"{BaseUrl2}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var dont_sent = JsonConvert.DeserializeObject<List<int>>(content);

            return dont_sent;
        }


    }

}
