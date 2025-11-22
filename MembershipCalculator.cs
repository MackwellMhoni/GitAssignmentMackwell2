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
			if (customer.MembershipType == "Regular")
			{
				return 400 * months;
			}
			else if (customer.MembershipType == "Premium")
			{
				return months < 12 ? 600 * months : (500 * months) + 200;
			}
			else if (customer.MembershipType == "VIP")
			{
				return months < 18 ? 900 * months : (550 * months) + 300;
			}
			else
			{
				return 0.00; // What Now? Is this even right?
			}
		}
	}
}
