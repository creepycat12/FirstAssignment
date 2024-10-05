namespace WestCoastEducation;

class Program
{
    static List<Student> students = new List<Student>();
    static List<Teacher> teachers = new List<Teacher>();
    static List<Courses> courses = new List<Courses>();
    static void Main(string[] args)
    {
        var studentOne = new Student("Olga", "Babkina", 0761829906, "Olga@gmail.com", 0406120162, "Barkåkragatan 10", "216 22", "Malmö", 123);
        students.Add(studentOne);

        var courseOne = new Courses("101", "Math Basics", 5, DateTime.Now, DateTime.Now.AddMonths(1), "Online");
        courses.Add(courseOne);

        ListStudents();
        ListCourses();
}

 static void ListStudents()
    {
        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }

static void ListCourses()
    {
        Console.WriteLine("List of Courses:");
        foreach (var course in courses)
        {
            Console.WriteLine(course.ToString());
        }
    }
}
