namespace WestCoastEducation;

public class TeacherManager
{
    private List<Teacher> teachers;
    private List<Courses> courses;


    public TeacherManager(List<Teacher> teacherList, List<Courses> courseList)
    {
        this.teachers = teacherList;
        this.courses = courseList;
    }
    public Teacher FindTeacherID(string ID)
    {
        return teachers.FirstOrDefault(teacher => teacher.StaffID == ID)!;
    }

    public Courses FindCourseName(string courseTitle)
    {
        return courses.FirstOrDefault(course => course.Title == courseTitle)!;
    }
    public void AddNewTeachers(string firstName, String lastName, string phoneNumber, string email, string personalNumber, string address, string postalCode, string city, string expertise, string staffID)
    {
        var newTeacher = new Teacher(firstName, lastName, phoneNumber, email, personalNumber, address, postalCode, city, expertise, staffID);
        teachers.Add(newTeacher);
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"{firstName} {lastName} has been added as a teacher");
        Console.ResetColor();
    }
    public void AssignTeacherToCourse(string ID, string courseTitle)
    {
        // Find the teacher by name
        Teacher teacher = FindTeacherID(ID);
        if (teacher == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Teacher with ID {ID} not found");
            Console.ResetColor();
            return;
        }

        // Find the course by title
        Courses course = FindCourseName(courseTitle);
        if (course == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Course {courseTitle} not found");
            Console.ResetColor();
            return;
        }

        // Assign the teacher to the course
        if (course.AssignedTeacher != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Unable to assign {teacher.FirstName} {teacher.LastName} to course {course.Title} because it already has a teacher");
            Console.ResetColor();
        }
        else
        {
            teacher.AddTeachesIn(course);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Teacher {teacher.FirstName} {teacher.LastName} assigned to course {course.Title}");
            Console.ResetColor();
        }
    }
    public void RemoveTeacher(string ID)
{
    Teacher teacher = FindTeacherID(ID);

    if (teacher != null)
    {
        teachers.Remove(teacher);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Teacher {teacher.FirstName} {teacher.LastName} has been removed as a teacher");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Teacher with ID {ID} not found.");
        Console.ResetColor();
    }
}

}
