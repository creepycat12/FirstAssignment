namespace WestCoastEducation;

public class Admin : EducationManager
{
    public List<Courses> ManagedCourses { get; set; } = new List<Courses>();
    public Admin(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city, string expertise, string staffID, DateTime hired)
        : base(firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city, expertise, staffID, hired)
    {

    }

    public void AddManagedCourses(Courses course)
    {
        if (course.CourseAdmin == null)
        {
            ManagedCourses.Add(course);
            course.CourseAdmin = this;
        }
        else
        {
            System.Console.WriteLine($"Unable to assign {FirstName} {LastName} to {course.Title} because it already has an Admin {course.CourseAdmin.FirstName} {course.CourseAdmin.LastName}");
        }
    }

    public override string ToString()
    {
        return $"Admin: {FirstName} {LastName} Managing: {ManagedCourses.Count} courses\n Hired on {Hired.ToShortDateString()}";
    }
}
