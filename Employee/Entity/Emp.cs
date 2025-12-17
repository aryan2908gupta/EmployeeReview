using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Entity
{
    public class Emp
    {
        private int id;
        private string name;
        private string email;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
               
                if (value > 0)
                    salary = value;
                else
                    salary = 0;
            }
        }

        public Emp(int id, string name, string email, double salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
        }



    }
}
