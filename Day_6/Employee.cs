using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        public  Employee (int _Id,string _Name,double _Salary)
        {
            EmpId = _Id;
            Name = _Name;
            Salary = _Salary;
        }

        public int EmployeeId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public string EmployeeName
        {
            get { return Name; }
            set { Name = value; }
        }


        public double EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public override string ToString()
        {
            return $"Employee ID: {EmpId}, Name: {Name}, Salary: {Salary}";
        }
    }
}
