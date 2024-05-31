namespace DepartmentCourse
{
    public static class Config
    {
        public static string server = "192.168.50.192";
        public static string database = "dpt";
        public static string uid = "osu";
        public static string password = "12345678";

        public static string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";
    }
}
