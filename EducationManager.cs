namespace WestCoastEducation;

public class EducationManager : Teacher
{
    public DateTime Hired { get; set; }
    public List<Courses> ResponsibleCourses { get; set; } = new List<Courses>();

    public EducationManager(string firstname, string lastname, int phonenumber, string email, int personalnumber, string address, string postalcode, string city, string expertise, DateTime hired)
    : base (firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city, expertise)
    {
     Hired = hired;   
    }
    public void AddResponsibleCourses (Courses courses){
        ResponsibleCourses.Add(courses);

    }
    

}
