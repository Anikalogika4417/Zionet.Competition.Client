using System.Net.Http.Json;
using ClientEntity;
using Microsoft.AspNetCore.Components.Forms;

namespace Zionet.Competition.Client.Services
{
    public class DataService
    {
        HttpClient http;

        public DataService(HttpClient httpClient)
        {
            http = httpClient;
        }

        public async Task<List<MCategory>> GetCategory()
        {
            return await http.GetFromJsonAsync<List<MCategory>>
                ($"https://localhost:44361/api/Category");
        }

        public async Task<List<MTask>> GetTask()
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task");
        }

        public async Task PostTask(MTask task) {
            await http.PostAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }
    }
}