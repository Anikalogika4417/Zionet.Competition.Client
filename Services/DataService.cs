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

        public async Task<List<MTask>> GetMainTasks()
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task/MainTask");
        }

        public async Task<List<MTask>> GetTaskById(int id_task)
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task/ById?_id={id_task}");
        }

        
        public async Task<List<MBonusToTask>> GetBonusTaskByMainId(int id_main_task)
        {
            return await http.GetFromJsonAsync<List<MBonusToTask>>
                ($"https://localhost:44361/api/BonusTask/ByMainId?_id={id_main_task}");
        }

        public async Task<List<MBonusToTask>> GetAllBonusTask()
        {
            return await http.GetFromJsonAsync<List<MBonusToTask>>
                ($"https://localhost:44361/api/BonusTask");
        }

        public async Task UpdateTask(MTask task)
        {
            await http.PutAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }


        public async Task PostTask(MTask task) {
            await http.PostAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }

    }
}