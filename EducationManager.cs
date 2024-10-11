namespace WestCoastEducation;

public class EducationManager : Teacher
{
    public DateTime Hired { get; set; }
    public List<Courses> ResponsibleCourses { get; set; } = new List<Courses>();

    public EducationManager(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city, string expertise, string staffID, DateTime hired)
    : base(firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city, expertise, staffID)
    {
        Hired = hired;
    }

    public Courses safecourse (List<Courses> courseList, int index) //funkar ej :(
    {
        try
        {
            return courseList[index];
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: Index {index} is out of bounds. {ex.Message}");
            return null!;
        }
    }
    public void AddResponsibleCourses(Courses course)
    {
        if (course.CourseLeader == null)
        {
            ResponsibleCourses.Add(course);
            course.CourseLeader = this;
        }
        else
        {
            System.Console.WriteLine($"Unable to assign {FirstName} {LastName} to {course.Title} because it already has an EducationManager {course.CourseLeader.FirstName} {course.CourseLeader.LastName}");
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} \n Courseleader in: {ResponsibleCourses.Count} courses \n Hired on: {Hired.ToShortDateString()}";
    }


}
