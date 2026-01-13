using Microsoft.Data.SqlClient;


namespace AdonetExample
{
    public class SqlUtility
    {
        private readonly string _connectionString;

        // Constructor
        public SqlUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Method
        public void ExecuteSQL(string sql)
        {
            
            using SqlConnection connection = new SqlConnection(_connectionString);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            using SqlCommand command = new SqlCommand(sql, connection);
           
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);

            connection.Close();
        }
    }
}
