using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Advanced
{
    internal class Employee: IComparable<Employee>
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

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
        public override bool Equals(object? obj)
        {
            Employee? employee = obj as Employee;
            if (employee is null) {
                return false;
            }
            return employee.Id == Id && employee.Name==Name && employee.Salary == Salary ;
        }
        public override int GetHashCode() { 
            return HashCode.Combine(Id, Name, Salary);
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) {
                return 1;
            }
             return Id.CompareTo(other.Id);
        }
    }
}
