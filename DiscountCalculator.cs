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
			return customer.Mem.CalculateDiscount(customer);
		}
	}
}
