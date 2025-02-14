namespace SessionScheduleApp;

public class Teacher
{
    public string Name { get; set; }
    public string Department { get; set; }
    
    public Teacher(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public void DisplayTeacherInfo()
    {
        Console.WriteLine("Преподаватель: " + Name + ", кафедра: " + Department);
    }

    public void UpdateTeacherInfo(string name, string department)
    {
        Name = name;
        Department = department;
    }
}