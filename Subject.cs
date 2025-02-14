namespace SessionScheduleApp;

public class Subject
{
    public string SubjectName { get; set; }

    public Subject(string subjectName)
    {
        SubjectName = subjectName;
    }

    public void DisplaySubjectInfo()
    {
        Console.WriteLine("Предмет: " + SubjectName);
    }

    public void UpdateSubjectName(string subjectName)
    {
        SubjectName = subjectName;
    }
}