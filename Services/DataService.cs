using System.Net.Http.Json;
using ClientEntity;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;


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

        public async Task PutCategory(MCategory category)
        {
            await http.PutAsJsonAsync<MCategory>
                ($"https://localhost:44361/api/Category", category);
        }

        public async Task PostCategory(MCategory category)
        {
            await http.PostAsJsonAsync<MCategory>
                ($"https://localhost:44361/api/Category", category);
        }

        public async Task<List<MCompetition>> GetCompetitions()
        {
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition");
        }

        public async Task<List<MCompetition>> GetCompetitionById(int id_competition)
        {
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition/ById?_id={id_competition}");
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

        public async Task<List<MConnectionCompToTask>> GetTasksByIdComp(int id_comp)
        {
            return await http.GetFromJsonAsync<List<MConnectionCompToTask>>
                ($"https://localhost:44361/api/TaskToCompetition/ByIdComp?_id={id_comp}");
        }

        public async Task<List<MConnectionCompToCategory>> GetCategoriesByIdComp(int id_comp)
        {
            return await http.GetFromJsonAsync<List<MConnectionCompToCategory>>
                ($"https://localhost:44361/api/Categoty_to_competition/ByCompId?_id={id_comp}");
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


        public async Task<List<MGroup>> GetGroups()
        {
            return await http.GetFromJsonAsync<List<MGroup>>
                ($"https://localhost:44361/api/Group");
        }

        public async Task<List<MGroup>> GetGroupsByIdComp(int id_comp)
        {
            return await http.GetFromJsonAsync<List<MGroup>>
                ($"https://localhost:44361/api/Group/ByIdComp?_id={id_comp}");
        }

        public async Task PostTask(MTask task) {
            var a = await http.PostAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }
        public async Task GetFiles() {
            var a = await http.GetFromJsonAsync<List<MUploadFile>>($"https://localhost:44361/api/TestFile");
            foreach (var taska in a)
                    {
                        Console.WriteLine(taska.FileName);
                    }
        }

    }
}