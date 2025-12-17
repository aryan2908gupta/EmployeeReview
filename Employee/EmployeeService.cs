using Employee.Interface;
using Employee.Entity;
using System;

namespace Employee
{
    public class EmployeeService : IEmployeeService
    {
        private Emp[] employees = new Emp[10];
        private int count = 0;

        public void AddEmployee(Emp employee)
        {
            if (count >= 10)
            {
                Console.WriteLine("Maximum 10 employees are allowed.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == employee.Id)
                {
                    Console.WriteLine("Duplicate Employee ID not allowed.");
                    return;
                }

                if (employees[i].Email == employee.Email)
                {
                    Console.WriteLine("Duplicate Email not allowed.");
                    return;
                }
            }

            if (employee.Salary <= 0)
            {
                Console.WriteLine("Salary must be greater than 0.");
                return;
            }

            employees[count++] = employee;
            Console.WriteLine("Employee added successfully.");
        }

        public void UpdateEmployee(int id, string name, string email, double salary)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].Name = name;
                    employees[i].Email = email;
                    employees[i].Salary = salary;
                    Console.WriteLine("Employee updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    employees[count - 1] = null;
                    count--;
                    Console.WriteLine("Employee deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public void DisplayEmployees()
        {
            for (int i = 0; i < count-1; i++) { 
            for(int j = i + 1; j < count; j++)
                {
                    if (employees[i].Name.Length > employees[j].Name.Length)
                    {
                        Emp temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    $"ID: {employees[i].Id}, " +
                    $"Name: {employees[i].Name}, " +
                    $"Email: {employees[i].Email}, " +
                    $"Salary: {employees[i].Salary}"
                );
            }
        }
    }
}
