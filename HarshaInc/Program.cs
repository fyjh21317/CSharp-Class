
using System.Collections.Generic;

class HarshaInc
{
    static void Main()
    {
        // Create a list of employees
        List<Employee> empList = new List<Employee>();

        for (int i = 0; i < 5; i++)
        {
            empList.Add(new Employee("Finance Department"));
        }

        // Initialize the employee details from user input
        foreach (Employee emp in empList)
        {
            System.Console.WriteLine("Enter Employee ID: ");
            emp.EmpID = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter Employee Name: ");
            emp.EmpName = System.Console.ReadLine();

            System.Console.WriteLine(System.String.Format("Enter Salary per hour for {0}: ", emp.EmpName));
            emp.SalaryPerHour = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(System.String.Format("Enter No of working hours for {0}: ", emp.EmpName));
            emp.NoOfWorkingHours = int.Parse(System.Console.ReadLine());

            emp.NetSalary = emp.SalaryPerHour * emp.NoOfWorkingHours;

            // Display the employee details
            System.Console.WriteLine(System.String.Format("Employee ID: {0}", emp.EmpID));
            System.Console.WriteLine(System.String.Format("Employee Name: {0}", emp.EmpName));
            System.Console.WriteLine(System.String.Format("Salary per hour: {0}", emp.SalaryPerHour));
            System.Console.WriteLine(System.String.Format("No of " +
                "working hours: {0}", emp.NoOfWorkingHours));
            System.Console.WriteLine(System.String.Format("Net Salary: {0}", emp.NetSalary));

            System.Console.WriteLine("Do you want to continue to next employee?");
            string response = System.Console.ReadLine();

            // if the user enters 'yes', then contibue to the next employee
            if (response.ToLower() == "yes")
            {
                System.Console.WriteLine("-------------------------------------------------");
                continue;
            } else { break; }
            
        }
        System.Console.WriteLine("Thank you for using the application!");
        System.Console.ReadKey();
    }
}