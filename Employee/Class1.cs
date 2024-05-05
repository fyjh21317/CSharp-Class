public class Employee
{
    public int EmpID;
    public string EmpName;
    public int SalaryPerHour;
    public int NoOfWorkingHours;
    public int NetSalary;

    public static string OrganizationName = "Harsha Inc";
    public const string TypeOfEmployee = "Contract Based";
    public readonly string DepartmentName;

    // constructor
    public Employee(string Name)
    {
        DepartmentName = Name;
    }
}
