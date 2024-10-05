namespace WestCoastEducation;

public class Student : Person
{
 public int StudentID { get; set; }  
 public List<Courses> EnrolledCourses { get; set; } = new List<Courses>(); 


public Student(string firstname, string lastname, int phonenumber, string email, int personalnumber, string address, string postalcode, string city, int studentID)
:base (firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city)

{
    StudentID = studentID;
}

public void AddEnrolledCourses(Courses course){
    EnrolledCourses.Add(course);
}
    public override string ToString()
    {
        return $" Student Name: {FirstName} {LastName} \n Student ID: {StudentID}\n Enrolled in {EnrolledCourses.Count} courses.";
    }
}
