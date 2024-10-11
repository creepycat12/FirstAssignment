namespace WestCoastEducation;

public class Courses
{
    public string CourseNumber { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public DateTime Start { get; set; }
    public DateTime Finish { get; set; }
    public string Location { get; set; }


    //Relationships
    public EducationManager? CourseLeader { get; set; }
    public Admin? CourseAdmin { get; set; }
    public List<Student> AmountStudents { get; set; } = new List<Student>(); //to keep stack of students enrolled into 1 course
    public Teacher? AssignedTeacher { get; set; }
    public Courses(string coursenumber, string title, int duration, DateTime start, DateTime finish, string location)
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
        string teacherName = "";
        if (AssignedTeacher != null)
        {
            teacherName = $"{AssignedTeacher.FirstName} {AssignedTeacher.LastName}";
        }
        else
        {
            teacherName = "No teacher assigned";
        }

        return $"CourseNumber: {CourseNumber}, Title: {Title}, Duration: {Duration} weeks\n Time Period: {Start.ToShortDateString()} - {Finish.ToShortDateString()} \n Location: {Location}, Teacher: {teacherName}";

    }
}
