using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Employee {
		public string Name { get; set; }
		public string Position { get; set; }
		public decimal Salary { get; set; }
		public Manager Manager { get; set; }
		public int VacationDays { get; set; }

		private int EmployeeOnly = 0; //setting this as private means it will not be received by the Manager derived class

		//Print method that prints Employee data
		public virtual string Print() { //adding "virtual" tells .NET to call the right print method based on what the object really is and not how it is declared
			return $"Name {Name} Salary {Salary} Position {Position}";
		}

		public void GiveRaise() {
			//add a method to give raises here
		}
	}
}
