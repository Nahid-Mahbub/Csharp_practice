using AdonetExample;

var connectionString = "Server=.\\SQLEXPRESS;Database=CSharpB22;User Id=CSharpB22;Password=624282;Trust Server Certificate = true";

var sql = "insert into students (name, CGPA, dateofbirth, isActive) values ('Naimur', 3.5, '2000-01-01', 1)";

SqlUtility utility = new SqlUtility(connectionString);
utility.ExecuteSQL(sql);
Console.WriteLine("Done");