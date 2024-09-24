using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PAMstudy.Models;

namespace PAMstudy.Services
{
    public class MonitorServices
    {

        private HttpClient client;
        private PAMstudy.Models.Monitor monitor;

        private List<Models.Monitor> monitores;

        private JsonSerializerOptions _serializerOptions;

        MonitorServices()
        {
            
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }
        public async Task<List<Models.Monitor>> GetAllMonitorAsync()
        {
            Uri uri = new Uri("http://localhost:8080/monitores");
            try
            {

                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();


                    monitores = JsonSerializer.Deserialize<List<Models.Monitor>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return monitores;
        }

    }
}
