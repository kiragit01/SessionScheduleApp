namespace SessionScheduleApp;

public class Exam
{
    public DateTime ExamTime { get; set; }
    public Group Group { get; set; }
    public Subject Subject { get; set; }
    public Auditorium Auditorium { get; set; }
    public Teacher Teacher { get; set; }

    public Exam(DateTime examTime, Group group, Subject subject, Auditorium auditorium, Teacher teacher)
    {
        ExamTime = examTime;
        Group = group;
        Subject = subject;
        Auditorium = auditorium;
        Teacher = teacher;
    }

    public void DisplayExamSchedule()
    {
        Console.WriteLine($"Экзамен по предмету '{Subject.SubjectName}' в {ExamTime:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"Группа: {Group.GroupName} сдает экзамен у преподавателя: {Teacher.Name}");
    }

    public void DisplayFullExamInfo()
    {
        Console.WriteLine($"Дата и время экзамена: {ExamTime:dd.MM.yyyy HH:mm}");
        Subject.DisplaySubjectInfo();
        Teacher.DisplayTeacherInfo();
        Auditorium.DisplayAuditoriumInfo();
        Group.DisplayGroupInfo();
    }
}