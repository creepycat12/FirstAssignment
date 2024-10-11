namespace WestCoastEducation;

public class Teacher : Person
{
    public string Expertise { get; set; }
    public string StaffID { get; set; }
    public List<Courses> TeachesIn { get; set; } = new List<Courses>();

    public Teacher(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city, string expertise, string staffID)
        : base(firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city)
    {
        Expertise = expertise;
        StaffID = staffID;
    }
    public void AddTeachesIn(Courses course)
    {
        if (course.AssignedTeacher == null)
        {
            TeachesIn.Add(course);
            course.AssignedTeacher = this;
        }
        else
        {
            System.Console.WriteLine($"Unable to assign {FirstName} {LastName} to {course.Title} because it already has a teacher {course.AssignedTeacher.FirstName} {course.AssignedTeacher.LastName}");
        }
    }

    public override string ToString()
    {
        return $" Teacher Name: {FirstName} {LastName}\n StaffID: {StaffID} \n Area of expertise: {Expertise}\n Teaches courses: {TeachesIn.Count} ";
    }
}
