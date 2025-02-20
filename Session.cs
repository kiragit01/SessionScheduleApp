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
    public void DisplayExcellentAndFailingStudents()
    {
        Random random = new Random();
        Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();

        foreach (var exam in Exams)
        {
            foreach (var student in exam.Group.Students)
            {
                if (!studentGrades.ContainsKey(student))
                {
                    studentGrades[student] = new List<int>();
                }
                int grade = random.Next(2, 6); 
                studentGrades[student].Add(grade);
                // Console.WriteLine($"Студент: {student}, предмет: {exam.Subject.SubjectName}, оценка: {grade}");
            }
        }
        List<string> excellentStudents = new List<string>();
        List<string> failingStudents = new List<string>();

        foreach (var kvp in studentGrades)
        {
            string student = kvp.Key;
            List<int> grades = kvp.Value;

            if (grades.All(g => g == 5))
                excellentStudents.Add(student);
            if (grades.Any(g => g == 2))
                failingStudents.Add(student);
        }

        Console.WriteLine("\nСписок отличников (5 по всем предметам):");
        if (excellentStudents.Count > 0)
        {
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("Нет отличников");
        }

        Console.WriteLine("\nСписок двоечников (хотя бы по одному предмету 2):");
        if (failingStudents.Count > 0)
        {
            foreach (var student in failingStudents)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("Нет двоечников");
        }
    }
}