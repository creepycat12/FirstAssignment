namespace WestCoastEducation;

public class Courses
{
public string CourseNumber { get; set; } 
public string Title { get; set; }
public int Duration { get; set; }
public DateTime Start { get; set; }
public DateTime Finish { get; set; }
public string Location { get; set; }

public Courses(string coursenumber, string title, int duration, DateTime start, DateTime finish, string location )
{
    CourseNumber = coursenumber;
    Title = title;
    Duration = duration;
    Start = start;
    Finish = finish;
    Location = location;   
}

    public override string ToString()
    {
        return $"Course: {CourseNumber} {Title} {Duration}\n Time Period: {Start} - {Finish} \n Location: {Location}";
    }
}
