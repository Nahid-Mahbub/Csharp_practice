using AdonetExample;
// আমরা আগে বানানো SqlUtility class ব্যবহার করছি, যা AdonetExample namespace-এ আছে

// ডাটাবেজের connection string define করা
// এখানে SQL Server instance, database name, user id, password, এবং trust server certificate setting আছে
var connectionString = "Server=.\\SQLEXPRESS;Database=CSharpB22;User Id=CSharpB22;Password=624282;Trust Server Certificate = true";

// INSERT SQL query, parameterized query ব্যবহার করা হয়েছে
var sql = "insert into students (name, CGPA, dateofbirth, isActive) values (@name, @cgpa, @dob, @isActive)";

// Parameters for the SQL command
// key = parameter name in SQL, value = actual value
Dictionary<string, object> parameters = new Dictionary<string, object>()
{
    {"@name", "Nahid"},
    {"@cgpa", 3.75},
    {"@dob", new DateTime(2000, 5, 15)},
    {"@isActive", true}
};

// উদাহরণ: DELETE SQL query (optional, এখন comment করা আছে)
// var deletsql = "delete from students where name = 'Fahim'";

// SELECT SQL query, data fetch করার জন্য
var querysql = "select * from students";

// SqlUtility object তৈরি করা, connection string পাঠানো হচ্ছে
SqlUtility utility = new SqlUtility(connectionString);

// INSERT বা DELETE চালানো যেতে পারে, এখন comment করা আছে
//utility.ExecuteSQL(deletsql);
//utility.ExecuteSQL(sql, parameters);

// SELECT query execute করা
utility.ExecuteQuery(querysql);
// যদি শুধু data fetch করতে হয়, তাহলে result capture করা ভালো

// SELECT query থেকে results capture করা
List<Dictionary<string, object>> students = utility.ExecuteQuery(querysql);

// প্রতিটা student row output করা
foreach (var student in students)
{
    // প্রতিটা column key + value দেখানো
    foreach (var kvp in student)
    {
        Console.Write($"{kvp.Key}: {kvp.Value}, ");
    }
    Console.WriteLine(); // প্রতিটা row শেষে new line
}

// শেষের confirmation message
Console.WriteLine("Done");
