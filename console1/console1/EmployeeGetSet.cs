using System;

namespace console1
{
    internal class EmployeeGetSet
    {
        private decimal salary;

        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public EmployeeGetSet()
        {
            EmpId = 1;
            EmpName = "Rohit";
            Salary = 25000;
        }

        public EmployeeGetSet(int id, string name, decimal salary)
        {
            EmpId = id;
            EmpName = name;
            Salary = salary;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
        }

        public bool IsPermanent()
        {
            return Salary >= 20000;
        }

        public override string ToString()
        {
            return $"Employee[Id:{EmpId}, Name:{EmpName}, Salary:{Salary}]";
        }
    }
}
