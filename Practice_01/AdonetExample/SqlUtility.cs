using Microsoft.Data.SqlClient; 
// SQL Server এর সাথে কাজ করার জন্য লাইব্রেরি। 
// SqlConnection, SqlCommand, SqlDataReader ইত্যাদি ব্যবহার করা যায়।

namespace AdonetExample
{
    public class SqlUtility
    {
        // ডাটাবেজের কানেকশন স্ট্রিং রাখা হবে এখানে
        // readonly মানে একবার set করলে আর পরিবর্তন করা যাবে না
        private readonly string _connectionString;

        // Constructor
        // Object বানানোর সময় connection string receive করা হচ্ছে
        public SqlUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Generic SQL command execute করার method (INSERT, UPDATE, DELETE, CREATE ইত্যাদি)
        // paramiters optional: SQL query তে parameters দিতে পারা যাবে
        public void ExecuteSQL(string sql, Dictionary<string, object>? paramiters = null)
        {
            // CreateCommand দিয়ে SqlCommand বানানো হচ্ছে
            // using এর মাধ্যমে auto dispose হবে এবং connection বন্ধ হবে
            using SqlCommand command = CreateCommand(sql, paramiters);

            // SQL execute করে কতগুলো row affected হলো তা পাওয়া
            int rowsAffected = command.ExecuteNonQuery();

            // Console এ affected rows দেখানো
            Console.WriteLine(rowsAffected);
        }

        // Query execute করার method (SELECT type command)
        // paramiters optional: SQL query তে parameters দিতে পারা যাবে
        public List<Dictionary<string, object>> ExecuteQuery(string queried, Dictionary<string, object>? paramiters = null)
        {
            // CreateCommand দিয়ে SqlCommand তৈরি করা
            using SqlCommand command = CreateCommand(queried, paramiters);

            // Result store করার জন্য list of dictionary
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            // SqlDataReader দিয়ে query execute এবং data read করা
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // প্রতিটা row dictionary হিসেবে রাখা
                Dictionary<string, object> row = new Dictionary<string, object>();

                // প্রতিটা column এর name এবং value row dictionary তে add করা
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }

                // প্রতিটা row results list এ add করা
                results.Add(row);
            }

            // সব row সহ list return করা
            return results;
        }

        // Private helper method যা SqlCommand তৈরি করে
        // paramiters: SQL query তে parameters থাকলে Add করে
        private SqlCommand CreateCommand(string sql, Dictionary<string, object> paramiters)
        {
            // নতুন SqlConnection তৈরি
            SqlConnection connection = new SqlConnection(_connectionString);

            // যদি connection বন্ধ থাকে তাহলে open করা
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            // SqlCommand তৈরি করা (SQL query + connection)
            SqlCommand command = new SqlCommand(sql, connection);

            // যদি parameters থাকে, তাহলে প্রতিটা parameter SqlCommand এ add করা
            if (paramiters is not null)
            {
                foreach (var paramiter in paramiters)
                {
                    // প্রতিটা parameter SqlCommand এ add করা
                    command.Parameters.AddWithValue(paramiter.Key, paramiter.Value);
                }
            }

            // তৈরি করা command return করা
            return command;
        }
    }
}
