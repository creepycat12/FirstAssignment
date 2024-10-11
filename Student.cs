namespace WestCoastEducation;

public class Student : Person
{
    public string StudentID { get; set; }
    public Courses? EnrolledCourse { get; set; }


    public Student(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city, string studentID)
    : base(firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city)

    {
        StudentID = studentID;
    }

    public void AddEnrolledCourse(Courses course)
    {
        if (EnrolledCourse != null)
        {
            System.Console.WriteLine($"Unable to place student {FirstName} {LastName} into course {course.Title}. A student can only attend one class at a time");
        }
        else if (course.AmountStudents.Count <= 32)
        {
            EnrolledCourse = course;
            course.AmountStudents.Add(this);
        }
        else
        {
            System.Console.WriteLine("This course is full");
        }
    }
    public override string ToString()
    {
        string courseInfo = "";
        if (EnrolledCourse != null)
        {
            courseInfo = EnrolledCourse.Title;
        }
        else
        {
            courseInfo = "Not enrolled in any course";
        }

        return $" Student Name: {FirstName} {LastName} \n Student ID: {StudentID}\n Enrolled in {courseInfo}";
    }
}
