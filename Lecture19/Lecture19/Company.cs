
public class Company
{
    public string Name;

    public List<Employee> Employees;
    public List<Team> Teams;
    public List<Department> Departments;

    public List<AttendanceRecord> AttendanceRecords;

    // Systém by měl umožňovat vyhledávání zaměstnanců podle různých kritérií,
    // jako je jméno, příjmení, pozice nebo oddělení.

    public Employee FindEmployeeByFirstName(string firstName)
    {
        return null;
    }

    public Employee FindEmployeeByLastName(string lastName)
    {
        return null;
    }

    public Employee[] FindEmployeesByPosition(string position)
    {
        return null;
    }

    public Employee[] FindEmployeesByDepartment(string departmentName)
    {
        return null;
    }
}
