namespace SessionScheduleApp;

public class Group
{
    public string GroupName { get; set; }
    public List<string> Students { get; set; }
    public string Faculty { get; set; }
    public int Course { get; set; }
    public string Specialty { get; set; }
    public int NumberOfStudents { get; set; }

    public Group(string groupName, string faculty, int course, string specialty, int numberOfStudents, List<string> students)
    {
        GroupName = groupName;
        Faculty = faculty;
        Course = course;
        Specialty = specialty;
        NumberOfStudents = numberOfStudents;
        Students = students;
    }

    public void DisplayGroupInfo()
    {
        Console.WriteLine("Группа: " + GroupName);
        Console.WriteLine("Факультет: " + Faculty);
        Console.WriteLine("Курс: " + Course);
        Console.WriteLine("Специальность: " + Specialty);
        Console.WriteLine("Количество студентов: " + NumberOfStudents);
        Console.WriteLine("ФИО всех студентов: ");
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }

    public void UpdateGroupInfo(string faculty, int course, string specialty, int numberOfStudents)
    {
        Faculty = faculty;
        Course = course;
        Specialty = specialty;
        NumberOfStudents = numberOfStudents;
    }
}