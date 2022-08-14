using System.Data.SqlClient;

namespace Dashboard_Statistics_App.Database
{
    public abstract class databaseConnection
    {
        private readonly string connectString;

        public databaseConnection()
        {
            connectString = "Server=DESKTOP-5HKHQO8\\SQLEXPRESS; DataBase=NorthwindStore; Integrated Security=true";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connectString);
        }
    }
}
