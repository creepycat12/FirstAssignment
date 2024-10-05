namespace WestCoastEducation;

public class Admin : EducationManager
{
    public List<Courses> ManagedCourses { get; set; } = new List<Courses>();
public Admin(string firstname, string lastname, int phonenumber, string email, int personalnumber, string address, string postalcode, string city, string expertise, DateTime hired)
    :base (firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city, expertise, hired)
{
    
}
public void AddManagedCourses(Courses courses){
    ManagedCourses.Add(courses);
}
}
