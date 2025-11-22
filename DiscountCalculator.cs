using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Assignment3
{
	public class DiscountCalculator
	{
		public double CalculateDiscount(Customer customer)
		{
			if (customer.MembershipType == "Regular")
			{
				return 0.05; // 5% discount
			}
			else if (customer.MembershipType == "Premium")
			{
				return 0.10; // 10% discount
			}
			else if (customer.MembershipType == "VIP")
			{
				return 0.20; // 20% discount
			}
			else
			{
				return 0.00; // No discount
			}
		}

	}
}
