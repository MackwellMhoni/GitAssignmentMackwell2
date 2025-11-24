using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Assignment3
{
	public class MembershipCostCalculator
	{
		public double CalculateMembership(Customer customer, int months)
		{
			return customer.Mem.CalculateMembership(customer, months);
		}
	}
}
