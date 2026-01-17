using EntityFramework;

// 👉 Database Context এর object তৈরি করা হচ্ছে
TrainingDbContext context = new TrainingDbContext();


// ======================
// INSERT OPERATION
// ======================

// 👉 নতুন Student object তৈরি
var students = new Students2
{
    Name = "Alice",                        // Student এর নাম
    CGPA = 3.8,                            // CGPA
    DateOfBirth = new DateTime(2000, 5, 15), // জন্ম তারিখ
    IsActive = true                        // Active status
};

// 👉 Students2 টেবিলে নতুন data যোগ করা হচ্ছে
context.Students2.Add(students);

// 👉 Database এ পরিবর্তন save করা হচ্ছে
context.SaveChanges();


// ======================
// READ OPERATION
// ======================

// 👉 Students2 টেবিলের সব data List আকারে আনা হচ্ছে
List<Students2> allStudents = context.Students2.ToList();
// ToList() মানে: পুরো table থেকে সব row নিয়ে আসা

// 👉 প্রতিটি student এর তথ্য print করা হচ্ছে
foreach (var student in allStudents)
{
    Console.WriteLine(
        $"ID: {student.Id}, " +
        $"Name: {student.Name}, " +
        $"CGPA: {student.CGPA}, " +
        $"DOB: {student.DateOfBirth.ToShortDateString()}, " +
        $"Active: {student.IsActive}"
    );
}


// ======================
// UPDATE OPERATION
// ======================

// 👉 Name দিয়ে একটি student খোঁজা হচ্ছে
// FirstOrDefault() → প্রথম যেটা পাবে সেটা দিবে, না পেলে null
Students2? studentsToUpdate = context.Students2
    .Where(s => s.Name == "Alice")
    .FirstOrDefault();

// 👉 যদি student পাওয়া যায় তাহলে update করা হবে
if (studentsToUpdate != null)
{
    studentsToUpdate.Name = "Alice Updated"; // নাম update
    studentsToUpdate.CGPA = 3.9;             // CGPA update

    // 👉 update save করা হচ্ছে
    context.SaveChanges();
}


// ======================
// DELETE OPERATION
// ======================

// 👉 delete করার জন্য student খোঁজা হচ্ছে
Students2? studentToDelete = context.Students2
    .Where(s => s.Name == "Alice Updated")
    .FirstOrDefault();

// 👉 যদি student পাওয়া যায় তাহলে delete করা হবে
if (studentToDelete != null)
{
    context.Students2.Remove(studentToDelete);

    // ⚠️ SaveChanges() অবশ্যই if block এর ভিতরে
    context.SaveChanges();
}
