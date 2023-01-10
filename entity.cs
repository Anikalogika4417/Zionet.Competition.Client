namespace ClientEntity
{

    public class UploadResult
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public string? ContentType { get; set; }
    }
    
    public class MCategory
    {
        public int id {get; set;}
         public string category_name { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class MTask
    {
        public int id {get; set;}
        public string task_name { get; set; }
        public string task_description { get; set; } 
        public string task_file_name { get; set; } 
        public int task_points { get; set; }
        public int task_duration { get; set; }
        public int id_category { get; set;}
        public bool is_bonus_task { get; set;}
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class RequestBonusToTask
    {
        public string id_main_task { get; set; }

    }

    public class MBonusToTask
    {
        public int id {get; set;}
        public int id_main_task { get; set; }
        public int id_bonus_task { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class MUploadFile
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public string? ContentType { get; set; }
    }

    public class MCompetition
    {
        public int id { get; set; }
        public string competition_name { get; set; }
        public DateTime competition_start { get; set; }
        public DateTime competition_end { get; set; }
        public int task_quantity { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class MConnectionCompToTask {
        public int id { get; set; }
        public int id_task { get; set; }
        public int id_competition { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class MConnectionCompToCategory {
        public int id { get; set; }
        public int id_category { get; set; }
        public int id_competition { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }

    public class MGroup {
        public int id { get; set; }
        public string group_name { get; set; }
        public string group_icon { get; set; }
        public int id_competition { get; set; }
        public int id_create_user { get; set; }
        public int id_update_user { get; set; }
        public DateTime create_date { get; set; }
        public DateTime update_date { get; set; }
        public int id_status { get; set; }
    }
}