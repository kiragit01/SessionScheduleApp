namespace SessionScheduleApp;

public class Session
{
    public List<Exam> Exams { get; set; }

    public Session()
    {
        Exams = new List<Exam>();
    }

    public void AddExam(Exam exam)
    {
        Exams.Add(exam);
    }

    public void DisplaySessionSchedule()
    {
        foreach (var exam in Exams)
        {
            exam.DisplayExamSchedule();
            Console.WriteLine(new string('-', 30));
        }
    }

    public void DisplayDetailedSessionInfo()
    {
        foreach (var exam in Exams)
        {
            exam.DisplayFullExamInfo();
            Console.WriteLine(new string('=', 30));
        }
    }
}