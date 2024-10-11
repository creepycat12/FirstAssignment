namespace WestCoastEducation;

public class StudentManager
{
    private List<Student> students;
    private List<Courses> courses;
    public StudentManager(List<Student> studentList, List<Courses> coursesList)
    {
        this.students = studentList;
        this.courses = coursesList;

    }

    public Student FindStudentID(string ID)
    {
        return students.FirstOrDefault(student => student.StudentID == ID)!;
    }
    public Courses FindCourseName(string courseTitle)
    {
        return courses.FirstOrDefault(course => course.Title == courseTitle)!;
    }

    public void AddNewStudent(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city, string studentID)
    {
        var newStudent = new Student(firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city, studentID);
        students.Add(newStudent);
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"{firstname} {lastname} has been added as a student");
        Console.ResetColor();
    }

    public void EnrollStudentInCourse(string ID, string courseTitle)
    {
        Student student = FindStudentID(ID);
        if (ID == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Student with ID {ID} not found");
            Console.ResetColor();
            return;
        }

        Courses course = FindCourseName(courseTitle);
        if (courseTitle == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Course {courseTitle} not found");
            Console.ResetColor();
            return;
        }

        if (student.EnrolledCourse != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Student {student.FirstName} {student.LastName} couldn't be enrolled in {course.Title} because they are currently enrolled into a different course");
            Console.ResetColor();
        }
        else
        {
            student.AddEnrolledCourse(course);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Student {student.FirstName} {student.LastName} has been enrollen into {course.Title}");
            Console.ResetColor();
        }
    }
    public void RemoveStudent(string ID)
    {
        Student student = FindStudentID(ID);

        if (student != null){
        Console.ForegroundColor = ConsoleColor.Green;
        students.Remove(student);
        System.Console.WriteLine($"{student.FirstName} {student.LastName} has been removed as a student");
        Console.ResetColor();
        }
        else
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Student with ID {ID} not found.");
        Console.ResetColor();
        }
    }

}
