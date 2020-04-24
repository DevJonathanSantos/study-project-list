using System.Globalization;

namespace MyListProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        
        }

        public override string ToString()
        {
            return "ID:"+Id
                + " || "
                + "Employee:"+ Name
                + " || "
                + "Salary:" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
