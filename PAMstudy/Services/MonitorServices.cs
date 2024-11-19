using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ObservableCollection<Models.Monitor> monitores;

        private JsonSerializerOptions _serializerOptions;

         public MonitorServices()
        {
            
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }
        public async Task<ObservableCollection<Models.Monitor>> GetAllMonitorAsync()
        {
            Uri uri = new Uri("http://localhost:8080/monitores");
            try
            {

                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();


                    monitores = JsonSerializer.Deserialize<ObservableCollection<Models.Monitor>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return monitores;
        }
       
        public async Task<Models.Monitor> GetMonitorByIdAsync(long id)
        {
            return monitor;
        }

        public async Task DeleteMonitorAsync(long id)
        {
            try
            {
                Uri uri = new Uri($"http://localhost:8080/monitores/{id}");
                client.DeleteAsync(uri);
            }
            catch(Exception ) { 
            
            }
        }

        public async Task UpdateMonitorAsync(long id)
        {

          
            try{
                Uri uri = new Uri($"http://localhost:8080/monitores/{id}");
                client.PutAsync(uri);
            }
            catch(Exception) {

            }
        }

    }
}
