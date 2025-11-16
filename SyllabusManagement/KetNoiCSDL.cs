using System.Data.SqlClient;

namespace SyllabusManagement
{
    public static class KetNoiCSDL
    {
        private static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\VS_LTTQ\SyllabusManagement\SyllabusManagement\Database.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
