namespace SessionScheduleApp;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group("213 группа", "Факультет ИТ", 2, "ИСиП", 30,
        ["Барбарас Александр"
         , "Бортник Иван Артемович"
         , "Бура Артур Дмитриевич"
         , "Вернер Андрей Уриелович"
         , "Дабежа Максим Сергеевич"
         , "Давискиба Максим Александрович"
         , "Деде Иван Дмитриевич"
         , "Дидур Даниил Юрьевич"
         , "Доцин Даниил Владимирович"
         , "Журба Иван Сергеевич"
         , "Занделов Данил Павлович"
         , "Иордатий Кирилл Валерьевич"
         , "Кирчу Игорь "
         , "Кырлан Александра Олеговна"
         , "Лозинский Даниил Максимович"
         , "Макаренко Данил Александрович"
         , "Мартынов Даниил Анатольевич"
         , "Марущак Анатолий Сергеевич"
         , "Морошан Никита Павлович "
         , "Мотынга Иван Александрович"
         , "Павлин Кирилл Юрьевич"
         , "Розенцвит Михаил Александрович"
         , "Сагайдак Глеб Андреевич"
         , "Сакара Анна Ивановна"
         , "Сулак Екатерина Александровна"
         , "Ушаков Геннадий Геннадьевич"
         , "Чайковский Андриан Андреевич"
         , "Чепалыга Амалия Максимовна"
         , "Шевченко Александр Александрович"
         , "Шеленков Кирилл Вячеславович"]);

        Session session = new Session();

        Exam exam1 = new Exam(
            new DateTime(2025, 6, 1, 9, 0, 0),
            group,
            new Subject("Математика"),
            new Auditorium("101", "А", 40),
            new Teacher("Иванов И.И.", "Математический факультет")
        );
        session.AddExam(exam1);

        Exam exam2 = new Exam(
            new DateTime(2025, 6, 2, 11, 0, 0),
            group,
            new Subject("Физика"),
            new Auditorium("202", "Б", 35),
            new Teacher("Петров П.П.", "Физический факультет")
        );
        session.AddExam(exam2);

        Exam exam3 = new Exam(
            new DateTime(2025, 6, 3, 14, 0, 0),
            group,
            new Subject("Информатика"),
            new Auditorium("303", "В", 50),
            new Teacher("Сидоров С.С.", "Факультет ИТ")
        );
        session.AddExam(exam3);

        Exam exam4 = new Exam(
            new DateTime(2025, 6, 4, 9, 0, 0),
            group,
            new Subject("История"),
            new Auditorium("404", "Г", 30),
            new Teacher("Козлов К.К.", "Исторический факультет")
        );
        session.AddExam(exam4);

        Exam exam5 = new Exam(
            new DateTime(2025, 6, 5, 13, 0, 0),
            group,
            new Subject("Экономика"),
            new Auditorium("505", "Д", 45),
            new Teacher("Новиков Н.Н.", "Экономический факультет")
        );
        session.AddExam(exam5);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nВыберите опцию:");
            Console.WriteLine("1 - Показать расписание экзаменов (когда, какой экзамен, преподаватель, группа)");
            Console.WriteLine("2 - Показать информацию об аудиториях экзаменов");
            Console.WriteLine("3 - Показать информацию о преподавателях экзаменов");
            Console.WriteLine("4 - Показать информацию о группе, сдающей экзамен");
            Console.WriteLine("5 - Изменить данные группы");
            Console.WriteLine("6 - Изменить данные аудитории (пример для первого экзамена)");
            Console.WriteLine("7 - Показать список отличников и двоечников");
            Console.WriteLine("0 - Выход");

            Console.Write("Введите опцию: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nРасписание экзаменов:");
                    session.DisplaySessionSchedule();
                    break;
                case "2":
                    Console.WriteLine("\nИнформация об аудиториях экзаменов:");
                    foreach (var exam in session.Exams)
                    {
                        exam.Auditorium.DisplayAuditoriumInfo();
                        Console.WriteLine(new string('-', 30));
                    }
                    break;
                case "3":
                    Console.WriteLine("\nИнформация о преподавателях экзаменов:");
                    foreach (var exam in session.Exams)
                    {
                        exam.Teacher.DisplayTeacherInfo();
                        Console.WriteLine(new string('-', 30));
                    }
                    break;
                case "4":
                    Console.WriteLine("\nИнформация о группе:");
                    group.DisplayGroupInfo();
                    break;
                case "5":
                    Console.WriteLine("\nИзменение данных группы:");
                    Console.Write("Введите новый факультет: ");
                    string newFaculty = Console.ReadLine();
                    Console.Write("Введите новый курс: ");
                    int newCourse;
                    int.TryParse(Console.ReadLine(), out newCourse);
                    Console.Write("Введите новую специальность: ");
                    string newSpecialty = Console.ReadLine();
                    Console.Write("Введите новое количество студентов: ");
                    int newStudents;
                    int.TryParse(Console.ReadLine(), out newStudents);
                    group.UpdateGroupInfo(newFaculty, newCourse, newSpecialty, newStudents);
                    Console.WriteLine("Данные группы обновлены.");
                    break;
                case "6":
                    Console.WriteLine("\nИзменение данных аудитории для первого экзамена:");
                    Console.Write("Введите новый номер аудитории: ");
                    string newAudNum = Console.ReadLine();
                    Console.Write("Введите новый корпус: ");
                    string newBuilding = Console.ReadLine();
                    Console.Write("Введите новую вместимость: ");
                    int newCapacity;
                    int.TryParse(Console.ReadLine(), out newCapacity);
                    exam1.Auditorium.UpdateAuditoriumInfo(newAudNum, newBuilding, newCapacity);
                    Console.WriteLine("Данные аудитории обновлены.");
                    break;
                case "7":
                    session.DisplayExcellentAndFailingStudents();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверная опция. Повторите ввод.");
                    break;
            }
        }
    }
}