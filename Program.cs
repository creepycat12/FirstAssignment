using System.Runtime.ConstrainedExecution;

namespace WestCoastEducation;

class Program
{
    static List<Courses> courses = new List<Courses>();
    static List<Student> students = new List<Student>();
    static List<Teacher> teachers = new List<Teacher>();
    static List<EducationManager> educationManagers = new List<EducationManager>();
    static List<Admin> admins = new List<Admin>();
    static void Main(string[] args)
    {
        //creating instances of classes to manage students and teachers
        var teachermanager = new TeacherManager(teachers, courses);
        var studentmanager = new StudentManager(students, courses);

        //calling methods with existing dummies :)
        DummyTeachers();
        DummyStudents();
        DummyEducationManager();
        DummyAdmins();
        DummyCourses();

        //Here you can create students and teachers, remove them, assign them to courses etc
        teachermanager.AssignTeacherToCourse("T101", "Math2");
        teachermanager.AssignTeacherToCourse("T102", "Web-design1");
        teachermanager.AssignTeacherToCourse("T103", "Programming1");
        System.Console.WriteLine(" ");

        teachermanager.AddNewTeachers("Michael", "Gustavsson", "076 123 45 67", "michael@gmail.com", "19800101-1234", "Malmöbägen 3", "777", "Göteborg", "Software-development", "T104");
        teachermanager.AssignTeacherToCourse("T104", "English5");
        teachermanager.AssignTeacherToCourse("T104", "Math2");
        teachermanager.RemoveTeacher("T101");
        System.Console.WriteLine(" ");

        studentmanager.EnrollStudentInCourse("STU201", "Math2");
        studentmanager.EnrollStudentInCourse("STU202", "Web-design1");
        studentmanager.EnrollStudentInCourse("STU203", "Math2");
        System.Console.WriteLine("");

        studentmanager.AddNewStudent("Laura", "Jakobsen", "0764852395", "laura@gmail.com", "20040228-1234", "Toftebakken 3", "4000", "Roskilde", "STU204");
        studentmanager.EnrollStudentInCourse("STU204", "Web-design1");
        studentmanager.EnrollStudentInCourse("STU204", "English5");
        studentmanager.RemoveStudent("STU204");
        courses.Add(new Courses("5", "Teknik2", 8, new DateTime(2024,1,8), new DateTime(2024,1,8).AddMonths(2), "Classroom D13"));
        teachermanager.AssignTeacherToCourse("T104", "Teknik2");
        System.Console.WriteLine("");

        admins[0].AddManagedCourses(courses[1]);
        educationManagers[1].AddResponsibleCourses(courses[3]);
        admins[0].AddManagedCourses(courses[2]);

        Console.ForegroundColor= ConsoleColor.DarkBlue;
        System.Console.WriteLine("Staff, students and courses:");
        System.Console.WriteLine("");
        Console.ResetColor();
        
        //Listing the courses, students and staff
        ListTeachers();
        ListCourses();
        ListStudents();
        ListLeaders();
        ListAdmins();
    }
    public static void DummyTeachers()
    {
        // creating dummy teachers
        teachers.Add(new Teacher("Thomas", "Croneman", "0764582209", "thomas@gmail.com", "19900101-8374", "Sjögatan 3", "123 45", "Lund", "Programming", "T101"));
        teachers.Add(new Teacher("Isabella", "Lundkvist", "0761839904", "Isabella@gmail.com", "19780109-2920", "Drottninggatan 7", "216 22", "Malmö", "Math", "T102"));
        teachers.Add(new Teacher("Per", "Svensson", "0761693763", "per@gmail.com", "19710519-2748", "Amriralsgatan 9", "234 92", "Vellinge", "Web-design", "T103"));
    }

    public static void DummyStudents()
    {
        //creating dummy students
        students.Add(new Student("Anwen", "Savage", "0763281214", "anwen@gmail.com", "2005041943", "Sandsgårdsvägen", "26754", "Oxie", "STU201"));
        students.Add(new Student("Eddie", "Lu", "0763827403", "Eddie@gmail.com", "1994012218", "Tessinsväggen 12", "23361", "Malmö", "STU202"));
        students.Add(new Student("Hugo", "Nilsson", "076937412", "hugo@gmail.com", "2004050912", "Annelundsvägen 56", "13489", "Skanör", "STU203"));
    }

    public static void DummyEducationManager()
    {
        //Assigning dummy education leaders
        educationManagers.Add(new EducationManager("Sara", "Olsson", "076129374", "sara@gmail.com", "19710513", "Hardvallsgatan 10", "211 22", "Malmö", "IT", "ED301", new DateTime(2013, 04, 12)));
        educationManagers.Add(new EducationManager("Tatiana", "Lapina", "0765050990", "Tatiana@gmail.com", "1978010958", "Barkåkragatan 10", "216 22", "Limhamn", "Gymnasie-kurser", "ED302", new DateTime(2017, 09, 28)));
    }

    public static void DummyAdmins()
    {
        //Creating a dummmy admin
        admins.Add(new Admin("Olga", "Babkina", "0742834498", "olga@gmail.com", "2004061201", "Himmesgatan 5", "234 77", "Malmö", "Administrator", "A401", new DateTime(2018, 09, 12)));
    }

    public static void DummyCourses()
    {
        //Creating dummy couses
        courses.Add(new Courses("1", "Programming1", 8, new DateTime(2004, 8, 8), new DateTime(2024, 08, 08).AddMonths(2), "Remote course"));
        courses.Add(new Courses("2", "Math2", 4, new DateTime(2004, 8, 8), new DateTime(2024, 08, 08).AddMonths(1), "Classroom 26C"));
        courses.Add(new Courses("3", "Web-design1", 8, new DateTime(2004, 8, 8), new DateTime(2024, 08, 08).AddMonths(2), "Remote course"));
        courses.Add(new Courses("4", "English5", 4, new DateTime(2004, 8, 8), new DateTime(2024, 08, 08).AddMonths(1), "Classroom A14"));
    }

    public static void ListTeachers()
    {
        Console.WriteLine("List of teachers:");
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher.ToString());
            System.Console.WriteLine("");
        }
    }

    static void ListCourses()
    {
        Console.WriteLine("List of Courses:");
        foreach (var course in courses)
        {
            Console.WriteLine(course.ToString());
            System.Console.WriteLine("");
        }
    }

    static void ListStudents()
    {
        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
            System.Console.WriteLine("");
        }
    }

    static void ListLeaders()
    {
        Console.WriteLine("List of Education Managers:");
        foreach (var leader in educationManagers)
        {
            Console.WriteLine(leader.ToString());
            System.Console.WriteLine("");
        }
    }

    static void ListAdmins()
    {
        Console.WriteLine("List of Admins:");
        foreach (var admin in admins)
        {
            Console.WriteLine(admin.ToString());
            System.Console.WriteLine("");
        }
    }


}

