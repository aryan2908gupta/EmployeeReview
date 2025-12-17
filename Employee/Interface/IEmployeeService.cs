using System;
using System.Collections.Generic;
using System.Text;
using Employee.Entity;

namespace Employee.Interface
{
  public interface IEmployeeService
    {
        void AddEmployee(Emp employee);
        void UpdateEmployee(int id, string name, string email, double salary);
        void DeleteEmployee(int id);
        void DisplayEmployees();
    }
}
