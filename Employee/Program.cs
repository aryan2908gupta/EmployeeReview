using Employee.Entity;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeService service = new EmployeeService();

            
            Emp e1 = new Emp(1, "Aryan", "aryan2908@gmail.com", 50000);
            Emp e2 = new Emp(2, "SahilKumar", "sahil123@gmail.com", 45000);
            Emp e3 = new Emp(3, "MSDhoni", "dhoni123@gmail.com", 60000);

            
            service.AddEmployee(e1);
            service.AddEmployee(e2);
            service.AddEmployee(e3);

            Console.WriteLine("\nEmployees after adding:");
            service.DisplayEmployees();
        }
    }
}
