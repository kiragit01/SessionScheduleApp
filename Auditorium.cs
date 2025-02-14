namespace SessionScheduleApp;

public class Auditorium
{
    public string AuditoriumNumber { get; set; }
    public string Building { get; set; }
    public int Capacity { get; set; }

    public Auditorium(string auditoriumNumber, string building, int capacity)
    {
        AuditoriumNumber = auditoriumNumber;
        Building = building;
        Capacity = capacity;
    }

    public void DisplayAuditoriumInfo()
    {
        Console.WriteLine("Аудитория №" + AuditoriumNumber + ", корпус " + Building + ", вместимость: " + Capacity);
    }

    public void UpdateAuditoriumInfo(string auditoriumNumber, string building, int capacity)
    {
        AuditoriumNumber = auditoriumNumber;
        Building = building;
        Capacity = capacity;
    }
}