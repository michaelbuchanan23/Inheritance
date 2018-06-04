using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Manager : Employee {
		//public List<Employee> Employees { get; set; }
		public decimal PurchaseAuth { get; set; }

		//public new void Print() { //generally we don't use the "new void" to hide this but rather we initialize it as below with an override
		public override string Print() {
			string msg = base.Print(); //calling the Print function from the Employee class that this Manager class inherited from
			return $"Manager: PurchaseAuth {PurchaseAuth} " + msg;
		}
	}
}
