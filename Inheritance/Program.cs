using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Program {
		static void Main(string[] args) {

			Employee e1 = new Employee();
			e1.Name = "John Doe";
			e1.Position = "Flunky";
			e1.Salary = 5999;
			e1.VacationDays = 0;
			//e1.Print();

			Manager m1 = new Manager();
			m1.Name = "Jane Doe";
			m1.Position = "Man-ager";
			m1.Salary = 6999;
			m1.VacationDays = 1;
			m1.PurchaseAuth = 10.99M; //have to add the "M" at the end so it formats correctly
			//m1.Print();

			e1.Manager = m1; //have to declare e1's manager down here because there was no m1 manager before this

			//declaring values for the administrator class
			Administrator a1 = new Administrator();
			a1.Name = "Jimmy Doe";
			a1.Position = "Assistant";
			a1.Salary = 3999;
			a1.VacationDays = 2;
			a1.Manager = m1;
			a1.AssignedTo = m1;

			List<Employee> employees = new List<Employee>();
			employees.Add(e1);
			employees.Add(m1); //this is putting the manager in the array as an employee variable (i.e. Employee m1 = new Manager();)
							   //looks at the variable type at runtime and determine if, even though we are putting it in as employee,
							   //treat it as a manager when we use virtual(in Employee) and override(in Manager) on the Print() method
			employees.Add(a1);

			foreach(Employee employee in employees) {
				string msg = employee.Print();
				Console.WriteLine(msg);
			}
		}
	}
}
