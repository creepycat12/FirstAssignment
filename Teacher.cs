namespace WestCoastEducation;

public class Teacher: Person
{
public string Expertise { get; set; }
public List<Courses> TeachesIn { get; set; } = new List<Courses>();

public Teacher(string firstname, string lastname, int phonenumber, string email, int personalnumber, string address, string postalcode, string city, string expertise)
    :base (firstname, lastname, phonenumber, email, personalnumber, address, postalcode, city)
{
    Expertise = expertise;
    
}
public void AddTeachesIn (Courses course){
    TeachesIn.Add(course);
}

    public override string ToString()
    {
        return $" Teacher Name: {FirstName} {LastName}\n Area of expertise: {Expertise}\n Teaches courses: {TeachesIn.Count} ";
    }
}
