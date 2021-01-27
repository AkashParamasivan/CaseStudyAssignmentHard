using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp3
{
	class Employee
	{
		int id, age;
		string name;
		double salary;
		
		public Employee()
		{
		}
		public Employee(int id, int age, string name, double salary)
		{
			this.id = id;
			this.age = age;
			this.name = name;
			this.salary = salary;
		}
		
		public void TakeEmployeeDetailsFromUser()
		{
			Console.WriteLine("Please enter the employee ID");
			id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the employee name");
			name = Console.ReadLine();
			Console.WriteLine("Please enter the employee age");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the employee salary");
			salary = Convert.ToDouble(Console.ReadLine());
		}
		public void DisplayMenu()
		{
			Console.WriteLine("Please enter the option");
			Console.WriteLine("1. Add an employee");
			Console.WriteLine("2. Modify an employee detail");
			Console.WriteLine("3. Print all employee's details");
			Console.WriteLine("4. Print an employee detail");
			Console.WriteLine("5. Exit");
			

		}
		//public void AddEmployeeDetails()
		//{ 

		//employees.Add(Id, Tuple.Create(Name, Age, Salary));

  //      }
		public override string ToString()
		{
			return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age +
		   "\nSalary : " + salary;
		}
		public int Id { get => id; set => id = value; }
		public int Age { get => age; set => age = value; }
		public string Name { get => name; set => name = value; }
		public double Salary { get => salary; set => salary = value; }
	}
}
