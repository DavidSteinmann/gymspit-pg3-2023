
// Firma chce také sledovat docházku zaměstnanců.
// Každý zaměstnanec má docházkový záznam s datem a časem příchodu a odchodu z práce.
public class AttendanceRecord
{
    public Employee Target;

    public TimeOnly EntryTime;
    public TimeOnly ExitTime;

    public AttendanceRecord(Employee target, TimeOnly entryTime, TimeOnly exitTime)
    {
        Target = target;
        EntryTime = entryTime;
        ExitTime = exitTime;
    }
}

