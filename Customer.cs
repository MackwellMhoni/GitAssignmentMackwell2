using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Assignment3
{

	public class Customer
	{
		public string Name { get; set; }
		public string MembershipType { get; set; }
		

		public Customer(string name, string membershipType)
		{
			Name = name;
			MembershipType = membershipType;
		}
	}
}
