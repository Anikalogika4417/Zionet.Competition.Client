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

        public async Task PostCategory(string _category_name)
        {
            var postBody = new 
            { 
                category_name = _category_name
            };
            using var response = await http.PostAsJsonAsync
                ($"https://localhost:44361/api/Category", postBody);
        }

        public async Task<List<MCompetition>> GetCompetitions()
        {
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition");
        }

         public async Task<List<MCompetition>> GetCompetitionsAbleReg()
        {
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition/AbleReg");
        }

        public async Task<List<MCompetition>> GetCompetitionById(int id_competition)
        {
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition/ById?_id={id_competition}");
        }

        public async Task<List<MCompetition>> GetCompetitionByUserId(string id_user){
            return await http.GetFromJsonAsync<List<MCompetition>>
                ($"https://localhost:44361/api/Competition/ByUserId?id_user={id_user}");
        }
        public async Task PutCompetition(MCompetition competition)
        {
            await http.PutAsJsonAsync<MCompetition>
                ($"https://localhost:44361/api/Competition", competition);
        }

        public async Task<List<MTask>> GetMainTasks()
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task/MainTask");
        }

        public async Task<List<MTask>> GetBonusTasks()
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task/BonusTask");
        }

        public async Task<List<MTask>> GetAllTasks()
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($" https://localhost:44361/api/Task/AllTasks");
        }
       

        public async Task<List<MTask>> GetTaskById(int id_task)
        {
            return await http.GetFromJsonAsync<List<MTask>>
                ($"https://localhost:44361/api/Task/ById?_id={id_task}");
        }

        public async Task<int> GetTaskIdByName(string task_name)
        {
            return await http.GetFromJsonAsync<int>
                ($"https://localhost:44361/api/TestTask/ByName?taskName={task_name}");
        }

        public async Task PostLinkTaskToCompetition(int _id_task, int _id_comp)
        {
            var postBody = new 
            { 
                id_task = _id_task, 
                id_competition = _id_comp
            };
            using var response = await http.PostAsJsonAsync("https://localhost:44361/api/TaskToCompetition", postBody);
        }


        public async Task<List<MConnectionTaskToGroup>> GetLinkTGbyIds(int id_group, int id_task){
            return await http.GetFromJsonAsync<List<MConnectionTaskToGroup>>
                ($"https://localhost:44361/api/TaskToGroup/ByGroupIdAnfTaskId?id_group={id_group}&id_task={id_task}");
        }

        public async Task PutConnectionLinkTG(MConnectionTaskToGroup link)
        {
            await http.PutAsJsonAsync<MConnectionTaskToGroup>($"https://localhost:44361/api/TaskToGroup", link);
        }
        
        public async Task<List<MConnectionTaskToGroup>> GetTasksToGroupByGroup(int id_group)
        {
            return await http.GetFromJsonAsync<List<MConnectionTaskToGroup>>
                ($"https://localhost:44361/api/TaskToGroup/ByGroupId?id_group={id_group}");
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

        public async Task<List<MBonusToTask>> GetLinkToBonusTask()
        {
            return await http.GetFromJsonAsync<List<MBonusToTask>>
                ($"https://localhost:44361/api/BonusTask");
        }

        public async Task PostLinkTaskToBonus(int _id_main_task, int _id_bonus_task)
        {
            var postBody = new 
            { 
                id_main_task = _id_main_task, 
                id_bonus_task = _id_bonus_task
            };
            using var response = await http.PostAsJsonAsync("https://localhost:44361/api/BonusTask", postBody);
        }


        public async Task UpdateTask(MTask task)
        {
            await http.PutAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }

        public async Task<List<MConnectionTaskToGroup>> GetTasksToGroup()
        {
            return await http.GetFromJsonAsync<List<MConnectionTaskToGroup>>
                ($"https://localhost:44361/api/TaskToGroup");
        }

        public async Task PostTaskToGroup(MConnectionTaskToGroup connection)
        {
            var response = await http.PostAsJsonAsync<MConnectionTaskToGroup>("https://localhost:44361/api/TaskToGroup", connection);
        }


        public async Task<List<MGroup>> GetGroups()
        {
            return await http.GetFromJsonAsync<List<MGroup>>
                ($"https://localhost:44361/api/Group");
        }

         public async Task<List<MGroup>> GetGroupsByUserId(string id_user)
        {
            return await http.GetFromJsonAsync<List<MGroup>>
                ($"https://localhost:44361/api/Group/ByUserId?id_user={id_user}");
        }


        

        public async Task<List<MGroup>> GetGroupsByIdComp(int id_comp)
        {
            return await http.GetFromJsonAsync<List<MGroup>>
                ($"https://localhost:44361/api/Group/ByCompId?_id={id_comp}");
        }

        public async Task PostGroup(MGroup group)
        {
            await http.PostAsJsonAsync<MGroup>
                ($"https://localhost:44361/api/Group", group);
        }

        public async Task PostTask(MTask task) {
            var a = await http.PostAsJsonAsync<MTask>($"https://localhost:44361/api/TestTask", task);
        }

        ///// Nodejs/////

        public async Task<Responce> GetUsers () {
            return await http.GetFromJsonAsync<Responce>("http://localhost:5000/getUsers");
        }

        public async Task<ResponceUserToGroup> GetUsersToGroup () {
            return await http.GetFromJsonAsync<ResponceUserToGroup>("http://localhost:5000/getUserToGroup");
        }

        public async Task AddUser(User postUserInfo) {
            await http.PostAsJsonAsync<User>("http://localhost:5000/addUser", postUserInfo);
        }

        public async Task updateUserToGroup(UpdateUserToGroup updateUserToGroupInfo) {
            await http.PostAsJsonAsync<UpdateUserToGroup>("http://localhost:5000/updateUserToGroup", updateUserToGroupInfo);
        }

        public async Task AddUserToGroup(UserToGroup postUserInfo) {
            await http.PostAsJsonAsync<UserToGroup>("http://localhost:5000/addUserToGroup", postUserInfo);
        }

        /////////////////
    }
}